using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Blocos
{
    internal static class SaveGame
    {
        public static int Numero { get; set; }
        public static string Nome { get; set; }
        public static Predio[,] Predios { get; set; }
        public static bool Tutorial { get; set; }
        public static int QtdeMoradores
        {
            get
            {
                int Qtde = 0;

                for (int y = 0; y < 3; y++)
                    for (int x = 0; x < 3; x++)
                        Qtde += Predios[x, y].Moradores;

                return Qtde;
            }
        }

        static SaveGame()
        {
            Reset();
        }

        public static void Reset()
        {
            Predios = new Predio[3, 3];
            Tutorial = true;

            for (int y = 0; y < 3; y++)
                for (int x = 0; x < 3; x++)
                    Predios[x, y] = new Predio(0, Blocos.TipoPredio.Vazio);
        }

        public static void Carregar(int NumSave)
        {
            FileStream save = new FileStream(Application.StartupPath + @"\Saves\Save " + NumSave + ".sav", FileMode.Open);

            byte[] buffer = new byte[20];
            //Carrega o nome
            save.Read(buffer, 0, 20);
            Nome = Encoding.Default.GetString(buffer, 0, 20);
            Nome = Nome.Replace(((char)0).ToString(), "");
            Nome.Trim();

            //Carrega os prédios
            for (int y = 0; y < 3; y++)
                for (int x = 0; x < 3; x++)
                {
                    save.Read(buffer, 0, sizeof(ushort));
                    Predios[x, y].Moradores = BitConverter.ToUInt16(buffer, 0);
                    Predios[x, y].TipoPredio = (Blocos.TipoPredio)save.ReadByte();
                }

            //Carrega a variável "Tutorial"
            Tutorial = Convert.ToBoolean(save.ReadByte());

            save.Close();
            save.Dispose();
        }

        public static void Salvar(int NumSave)
        {
            FileStream save = new FileStream(Application.StartupPath + @"\Saves\Save " + NumSave + ".sav", FileMode.Create);

            //Salva o nome
            save.Write(Encoding.Default.GetBytes(Nome.ToCharArray()), 0, Nome.Length);
            save.Position = 20;

            //Salva os prédios
            for (int y = 0; y < 3; y++)
                for (int x = 0; x < 3; x++)
                {
                    save.Write(BitConverter.GetBytes(Predios[x, y].Moradores), 0, sizeof(ushort));
                    save.WriteByte((byte)Predios[x, y].TipoPredio);
                }

            //Salvar a variável "Tutorial"
            save.WriteByte(Convert.ToByte(Tutorial));

            save.Close();
            save.Dispose();
        }
    }

    internal class Predio
    {
        public ushort Moradores { get; set; }
        public Blocos.TipoPredio TipoPredio { get; set; }

        public Predio(ushort Moradores, Blocos.TipoPredio TipoPredio)
        {
            this.Moradores = Moradores;
            this.TipoPredio = TipoPredio;
        }
    }
}
