using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace Blocos
{
    internal static class MenuItens
    {
        public static string Menu { get; set; }
        public static string NomeMenu { get; set; }
        public static int Selecionado { get; set; }
        public static List<MenuItem> Itens = new List<MenuItem>();

        public static void AbrirMenu(string menu)
        {
            Menu = menu;
            Itens.Clear();
            Selecionado = 0;
            switch (Menu)
            {
                case "Principal":
                    NomeMenu = "Blocos";
                    Itens.Add(new MenuItem("Continuar", "ContinuarJogo", !SaveGame.Tutorial));
                    Itens.Add(new MenuItem("Novo Jogo", "NovoJogo", true));
                    Itens.Add(new MenuItem("Salvar Jogo", "SaveGame.Salvar", true));
                    Itens.Add(new MenuItem("Instruções", "MostrarIntruções", false));
                    Itens.Add(new MenuItem("Opções", "AbrirMenu:Opções", false));
                    Itens.Add(new MenuItem("Sair", "Application.Exit", true));
                    break;
                case "Saves":
                    NomeMenu = "Selecione um save";
                    if (!Directory.Exists(Application.StartupPath + @"\Saves"))
                        Directory.CreateDirectory(Application.StartupPath + @"\Saves");

                    for (int i = 1; i <= 5; i++)
                    {
                        string NomeItem;
                        if (File.Exists(Application.StartupPath + @"\Saves\Save " + i + ".sav"))
                        {
                            SaveGame.Carregar(i);
                            NomeItem = SaveGame.Nome;
                        }
                        else
                            NomeItem = "<Vazio>";

                        Itens.Add(new MenuItem(NomeItem, "SelecSave:" + i, true));
                    }
                    Itens.Add(new MenuItem("Sair", "Application.Exit", true));
                    break;
                case "Criar Save":
                    NomeMenu = "Digite seu nome";
                    Itens.Add(new MenuItem("", "EscreverNome", true));
                    Itens.Add(new MenuItem("OK", "CriarSave", false));
                    Itens.Add(new MenuItem("Cancelar", "AbrirMenu:Saves", true));
                    break;
                case "Apagar Save":
                    SaveGame.Carregar(SaveGame.Numero);
                    NomeMenu = "Apagar Save " + SaveGame.Nome + "?";
                    Itens.Add(new MenuItem("Não", "AbrirMenu:Saves", true));
                    Itens.Add(new MenuItem("Sim", "SaveGame.Apagar:" + SaveGame.Numero, true));
                    break;
            }
        }
    }

    internal class MenuItem
    {
        public string Texto { get; set; }
        public string Funcao { get; set; }
        public bool Enabled { get; set; }

        public MenuItem(string Texto, string Funcao, bool Enabled)
        {
            this.Texto = Texto;
            this.Funcao = Funcao;
            this.Enabled = Enabled;
        }
    }
}
