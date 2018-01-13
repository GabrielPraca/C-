using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace Cimg
{
    class Cimg
    {
        public List<ElementoImg> Elementos { get; set; }
        public Rectangle Dimensao { get; set; }

        public Cimg(List<ElementoImg> Elementos, Rectangle Dimensao)
        {
            this.Elementos = Elementos;
            this.Dimensao = Dimensao;
        }

        public void Salvar(string Caminho)
        {
            string Save = "Cimg_V:1.0;\r\n";
            Save += string.Format("Dimensao:{0},{1},{2},{3};\r\n",
                                  Dimensao.X,
                                  Dimensao.Y,
                                  Dimensao.Width,
                                  Dimensao.Height);
            Save += string.Format("Elementos[{0}]: {{\r\n", Elementos.Count);
            int i = 0;
            foreach (ElementoImg elem in Elementos)
            {
                Save += string.Format("\t${0}\r\n\tTipo:{1};\r\n\tPontos[{2}]: {{\r\n", i++, (int)elem.Tipo, elem.Pontos.Count);
                int ii = 0;
                foreach (Point ponto in elem.Pontos)
                    Save += string.Format("\t\t${0}\r\n\t\tP:{1},{2};\r\n", ii++, ponto.X, ponto.Y);
                Save += "\t}\r\n";
                Save += string.Format("\tTamanho:{0};\r\n", elem.Tamanho);
                Save += string.Format("\tCor:{0},{1},{2},{3};\r\n", elem.Cor.A, elem.Cor.R, elem.Cor.G, elem.Cor.B);
            }
            Save += "}";

            StreamWriter Arquivo = new StreamWriter(Caminho);
            Arquivo.Write(Save);
            Arquivo.Close();
        }

        public static Cimg Carregar(string Caminho)
        {
            try
            {
                ElementoImg[] elems;
                Rectangle dim;
                StreamReader Arquivo = new StreamReader(Caminho);
                string Buffer = Arquivo.ReadToEnd();
                Arquivo.Close();
                string[] tmpAStr;

                int Seek = 0;

                if (getConteudoElemSave(ref Seek, "Cimg_V", ref Buffer) != "1.0")
                    return null;

                tmpAStr = getConteudoElemSave(ref Seek, "Dimensao", ref Buffer).Split(',');
                dim = new Rectangle(int.Parse(tmpAStr[0]), int.Parse(tmpAStr[1]), int.Parse(tmpAStr[2]), int.Parse(tmpAStr[3]));

                int QtdeElem = getQtdeElemSave(ref Seek, "Elementos", ref Buffer);
                elems = new ElementoImg[QtdeElem];
                for (int i = 0; i < QtdeElem; i++)
                {
                    Seek = Buffer.IndexOf("$" + i, Seek) + i.ToString().Length + 1;
                    TipoElem Tipo = (TipoElem)int.Parse(getConteudoElemSave(ref Seek, "Tipo", ref Buffer));

                    int QtdeP = getQtdeElemSave(ref Seek, "Pontos", ref Buffer);
                    Point[] Pontos = new Point[QtdeP];
                    for (int p = 0; p < QtdeP; p++)
                    {
                        Seek = Buffer.IndexOf("$" + p, Seek) + p.ToString().Length + 1;
                        tmpAStr = getConteudoElemSave(ref Seek, "P", ref Buffer).Split(',');
                        Pontos[p] = new Point(int.Parse(tmpAStr[0]), int.Parse(tmpAStr[1]));
                    }
                    float Tamanho = float.Parse(getConteudoElemSave(ref Seek, "Tamanho", ref Buffer));

                    elems[i] = new ElementoImg(Tipo, Pontos[0], Tamanho);
                    elems[i].Pontos.Clear();
                    elems[i].Pontos.AddRange(Pontos);
                    tmpAStr = getConteudoElemSave(ref Seek, "Cor", ref Buffer).Split(',');
                    elems[i].Cor = Color.FromArgb(byte.Parse(tmpAStr[0]),
                                                  byte.Parse(tmpAStr[1]),
                                                  byte.Parse(tmpAStr[2]),
                                                  byte.Parse(tmpAStr[3]));
                }
                List<ElementoImg> lElems = new List<ElementoImg>();
                lElems.AddRange(elems);
                return new Cimg(lElems, dim);
            }
            catch { }

            return null;
        }

        private static string getConteudoElemSave(ref int Seek, string elem, ref string Buffer)
        {
            int tam;
            elem += ':';
            Seek = Buffer.IndexOf(elem, Seek) + elem.Length;
            tam = Buffer.IndexOf(";", Seek) - Seek;
            Seek += tam;

            return Buffer.Substring(Seek - tam, tam);
        }

        private static int getQtdeElemSave(ref int Seek, string elem, ref string Buffer)
        {
            int tam, Qtde;
            elem += '[';
            Seek = Buffer.IndexOf(elem, Seek) + elem.Length;
            tam = Buffer.IndexOf("]:", Seek) - Seek;
            Qtde = int.Parse(Buffer.Substring(Seek, tam));
            Seek += tam;

            return Qtde;
        }
    }

    class RecursoImg
    {
        public string Nome { get; set; }
        public Bitmap Img { get; set; }

        public RecursoImg(string Nome, string Caminho)
        {
            this.Nome = Nome;
            Img = new Bitmap(Caminho);
        }
    }

    class ElementoImg
    {
        public TipoElem Tipo { get; set; }
        public List<Point> Pontos { get; set; }
        float _Tamanho;
        public float Tamanho { get { return _Tamanho; } set { _Tamanho = value; pCor.Width = value; } }
        Color _Cor;
        public Color Cor { get { return _Cor; } set { _Cor = value; bCor = new SolidBrush(value); pCor.Color = value; } }
        public Brush bCor { get; private set; }
        public Pen pCor { get; private set; }
        public float pWidth { get { return pCor.Width; } set { pCor.Width = value; } }

        public ElementoImg(TipoElem Tipo, Point Pos)
        {
            this.Tipo = Tipo;
            Pontos = new List<Point>();
            Pontos.Add(Pos);
            pCor = new Pen(Color.Black);
            Cor = Color.Black;
            Tamanho = 1;
        }

        public ElementoImg(TipoElem Tipo, Point Pos, float Tamanho)
        {
            this.Tipo = Tipo;
            Pontos = new List<Point>();
            Pontos.Add(Pos);
            pCor = new Pen(Color.Black);
            Cor = Color.Black;
            this.Tamanho = Tamanho;
        }
    }



    public enum TipoElem
    {
        POLIGONO = 1,
        RETANGULO = 1 << 1,
        CIRCULO = 1 << 2,
        PREENCHIDO = 1 << 3
    }
}
