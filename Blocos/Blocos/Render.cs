using System;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using Blocos.Properties;

using Tao.OpenGl;
using Tao.Platform.Windows;

namespace Blocos
{
    internal static class Render
    {
        static Guindaste GuindMenu = new Guindaste(false, 0);
        static List<Nuvem> NuvensMenu = new List<Nuvem>();
        static List<Fumaca> Fumacas = new List<Fumaca>();
        static List<Estrela> Estrelas = new List<Estrela>();
        static float AviaoX = 0;
        static Random rdn = new Random();
        static bool Carregado = false;

        internal static void RenderIntroducao(int Tick)
        {
            ClearRadial(Color.FromArgb(50, 50, 50), Color.Black, 50);

            if (Tick < 1000)
                return;
            //Desenha Logo
            Textura textura = Texturas.GetTextura("Logo");
            if (textura != null)
            {
                float TempoRelat = Math.Min(Tick - 1000, 1000) / 1000f, //3seg
                      w = textura.Width * TempoRelat,
                      h = textura.Height * TempoRelat;
                Gl.glColor4f(1, 1, 1, TempoRelat);
                Texturas.DrawTextura(textura, Screen.Width / 2 - w / 2, Screen.Height / 2 - h / 2, w, h, 0);
            }
            if (Tick >= 5000) //5seg é o tempo de todo essa animação, depois vai para a tela de "Carregando..."
                Carregar();
        }

        internal static void Carregar()
        {
            if (Carregado)
                return;

            //Muda para a tela de Carregamento
            Blocos.EstadoJogo = Blocos.EstadosJogo.CARREGANDO;
            Blocos.refTick = Environment.TickCount;
            Carregado = true;

            //Cria e compartilha um contexto para ser usado no thread
            IntPtr hDC = Wgl.wglGetCurrentDC(),
                   Main_hRC = Wgl.wglGetCurrentContext(),
                   Load_hRC = Wgl.wglCreateContext(hDC);
            Wgl.wglShareLists(Main_hRC, Load_hRC);

            #region Thread que carrega
            Thread Th = new Thread(new ThreadStart(() =>
            {
                Wgl.wglMakeCurrent(hDC, Load_hRC);

                Texturas.UnloadTextura("Logo");
                Texturas.LoadTextura("Fumaça", Application.StartupPath + @"\Recursos\Imagens\Fumaça.png");
                Texturas.LoadTextura("Fumaça 1", Application.StartupPath + @"\Recursos\Imagens\Fumaça 1.png");
                Texturas.LoadTextura("Estrela", Application.StartupPath + @"\Recursos\Imagens\Estrela.png");
                Texturas.LoadTextura("Avião", Application.StartupPath + @"\Recursos\Imagens\Avião.png");
                Texturas.LoadTextura("Árvore 1", Application.StartupPath + @"\Recursos\Imagens\Árvore 1.png");
                Texturas.LoadTextura("Árvore 2", Application.StartupPath + @"\Recursos\Imagens\Árvore 2.png");
                Texturas.LoadTextura("Grade", Application.StartupPath + @"\Recursos\Imagens\Grade.png");
                Texturas.LoadTextura("Prédios Fundo", Application.StartupPath + @"\Recursos\Imagens\Prédios Fundo.png");
                Texturas.LoadTextura("PopIco", Application.StartupPath + @"\Recursos\Imagens\PopIco.png");
                Texturas.LoadTextura("CurHand", Application.StartupPath + @"\Recursos\Imagens\CurHand.png");
                Texturas.LoadTextura("Base Cidade", Application.StartupPath + @"\Recursos\Imagens\Base Cidade.png");
                Texturas.LoadTextura("Andar Azul Porta", Application.StartupPath + @"\Recursos\Imagens\Prédios\Azul\Andar Porta.png");
                Texturas.LoadTextura("Andar Azul Janela", Application.StartupPath + @"\Recursos\Imagens\Prédios\Azul\Andar Janela.png");
                Texturas.LoadTextura("Andar Azul Teto", Application.StartupPath + @"\Recursos\Imagens\Prédios\Azul\Andar Teto.png");
                Texturas.LoadTextura("IcoPredio Azul", Application.StartupPath + @"\Recursos\Imagens\IcoPredio\Azul.png");
                Texturas.LoadTextura("IcoPredio Vermelho", Application.StartupPath + @"\Recursos\Imagens\IcoPredio\Vermelho.png");
                Texturas.LoadTextura("IcoPredio Verde", Application.StartupPath + @"\Recursos\Imagens\IcoPredio\Verde.png");
                Texturas.LoadTextura("IcoPredio Amarelo", Application.StartupPath + @"\Recursos\Imagens\IcoPredio\Amarelo.png");
                Fontes.LoadFonteFromFile("Nome Menu", Application.StartupPath + @"\Recursos\Fontes\Fonte 2.ttf", 40);
                Fontes.LoadFonteFromFile("Item Menu", Application.StartupPath + @"\Recursos\Fontes\Fonte 1.ttf", 20);
                Fontes.LoadFonte("Outros24", "Arial Black", 24);
                Sons.LoadSom("MudancaMenu", Application.StartupPath + @"\Recursos\Sons\MudancaMenu.wav");

                //Gera Nuvem do Menu
                for (int i = 0; i < 20; i++)
                {
                    Nuvem nuvem = new Nuvem(rdn.Next(Screen.Width), rdn.Next(Screen.Height), (float)(rdn.NextDouble() * 360), (float)(rdn.NextDouble() * 10) + 10, 20);
                    for (int j = 0; j < nuvem.Fumacas.Length; j++)
                        nuvem.Fumacas[j] = new Point(rdn.Next(128), rdn.Next(64));

                    NuvensMenu.Add(nuvem);
                }
                //Gera as Estrelas
                for (int i = 0; i < 300; i++)
                    Estrelas.Add(new Estrela((float)rdn.NextDouble() * Screen.Width, (float)rdn.NextDouble() * 7000 + 2000, (float)rdn.Next(20, 255) / 255f));

                MenuItens.AbrirMenu("Saves");

                //Vai para o menu
                Blocos.EstadoJogo = Blocos.EstadosJogo.MENU;
                Blocos.refTick = Environment.TickCount;

                //Deleta o contexto usado para carregar os recursos
                Wgl.wglMakeCurrent(IntPtr.Zero, IntPtr.Zero);
                Wgl.wglDeleteContext(Load_hRC);

                //Espera um tempo para descarregar os recursos iniciais
                Thread.Sleep(1000);
                Fontes.DisposeFonte("Carregando");
            }));
            #endregion

            Th.IsBackground = true;
            Th.Start();
        }

        internal static void RenderCarregando(int Tick)
        {
            ClearRadial(Color.FromArgb(50, 50, 50), Color.Black, 50);

            //Faz aquela rodinha na tela de Loading
            Glu.GLUquadric qObj = Glu.gluNewQuadric();
            float w = Screen.Width / 2,
                  h = Screen.Height / 2;

            Gl.glTranslatef(w, h, 0);

            //Meio Disco Vermelho
            Gl.glColor3f(0.8f, 0.1f, 0.1f);
            Glu.gluPartialDisk(qObj, 89, 120, 10, 10, -(Tick / 3), 45);
            //Meio Disco Verde
            Gl.glColor3f(0.1f, 0.6f, 0.1f);
            Glu.gluPartialDisk(qObj, 89, 120, 10, 10, (Tick / 5), 45);
            //Meio Disco Azul
            Gl.glColor3f(0.1f, 0.2f, 0.6f);
            Glu.gluPartialDisk(qObj, 89, 120, 10, 10, -(Tick / 8), 45);
            //Disco do Meio
            Gl.glColor3f(1, 1, 1);
            Glu.gluDisk(qObj, 0, 90, 40, 5);

            Gl.glTranslatef(-w, -h, 0);
            Glu.gluDeleteQuadric(qObj);

            //Escreve "Carregando..."
            Fonte fonte = Fontes.GetFonte("Carregando");
            SizeF TamFonte = fonte.MedirTexto("Carregando");
            Fontes.DrawString("Carregando" + "".PadRight(Tick / 250 % 4, '.'), fonte, Color.FromArgb(60, 60, 60), false, Screen.Width / 2 - TamFonte.Width / 2, Screen.Height / 2 - TamFonte.Height / 2);
        }

        internal static void RenderMenu(int Tick, float Avanco)
        {
            Textura textura;
            Fonte fonte;
            SizeF TamFonte;
            float x, y, rot;

            #region Desenha o fundo do menu
            ClearRadial(Color.AliceBlue, Color.FromArgb(0, 0x60, 0xFF), 30);

            //Cabo do Guindaste
            GuindMenu.ProgBalanco += (0.55f - ((GuindMenu.ProgBalanco > 0.5f ? GuindMenu.ProgBalanco : 1 - GuindMenu.ProgBalanco) - 0.5f)) * 2 * Avanco;
            rot = (GuindMenu.DirecDir ? 1f - GuindMenu.ProgBalanco : GuindMenu.ProgBalanco);
            x = Screen.Width / 2;
            y = Screen.Height * 2.5f;
            x -= Screen.Width * (float)Math.Cos((250 + 40 * rot) * (Math.PI / 180));
            y -= Screen.Height * 2 * -(float)Math.Sin((250 + 40 * rot) * (Math.PI / 180));

            Gl.glColor3f(0.1f, 0.1f, 0.1f);
            Gl.glLineWidth(3);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2f(Screen.Width / 2, Screen.Height * 2);
            Gl.glVertex2f(x, y);
            Gl.glEnd();

            //Andar preso ao guindaste
            textura = Texturas.GetTextura("Andar Azul Janela");
            Gl.glColor3f(1, 1, 1);

            Gl.glPushMatrix();
            Gl.glTranslatef(x, y, 0);
            Gl.glRotatef(20 - 40 * rot, 0, 0, 1);
            Gl.glTranslatef(-x, -y, 0);
            Texturas.DrawTextura(textura, x - textura.Width / 4, y - textura.Height / 2, textura.Width / 2, textura.Height / 2, 0);

            fonte = Fontes.GetFonte("Item Menu");
            Fontes.DrawString(string.Format("{0:0}°", 250 + 40 * rot), fonte, Color.White, true, x, y);

            Gl.glPopMatrix();

            //Desenha as nuvens
            Gl.glColor4f(1, 1, 1, 0.1f);
            textura = Texturas.GetTextura("Fumaça");
            foreach (Nuvem nuvem in NuvensMenu)
            {
                rot = nuvem.Rotacao;
                foreach (Point fumaca in nuvem.Fumacas)
                {
                    Texturas.DrawTextura(textura, nuvem.X + fumaca.X - 32, nuvem.Y + fumaca.Y - 32, 64, 64, -rot);
                    rot += 15;
                }
                if (nuvem.X < -128)
                {
                    nuvem.X = Screen.Width;
                    nuvem.Y = rdn.Next(Screen.Height);
                }
                nuvem.X -= nuvem.Velo * Avanco;

                nuvem.Rotacao += (10 * Avanco) % 360;

            }
            #endregion

            #region Escreve o Nome do Menu
            fonte = Fontes.GetFonte("Nome Menu");
            TamFonte = fonte.MedirTexto(MenuItens.NomeMenu);
            x = Screen.Width / 2 - TamFonte.Width / 2;
            y = Screen.Height - TamFonte.Height;

            Fontes.DrawString(MenuItens.NomeMenu, fonte, Color.White, true, x, y);
            #endregion

            #region Desenha os itens do menu
            fonte = Fontes.GetFonte("Item Menu");
            x = Screen.Width / 2;
            y = Screen.Height / 2 + (MenuItens.Itens.Count / 2f) * fonte.Height - fonte.Height;
            Color cor;

            for (int i = 0; i < MenuItens.Itens.Count; i++)
            {
                string textoItem = MenuItens.Itens[i].Texto;
                if (MenuItens.Itens[i].Funcao == "EscreverNome")
                    textoItem = textoItem.PadRight(20, '-');

                TamFonte = fonte.MedirTexto(textoItem);
                float tmpX = x - TamFonte.Width / 2,
                      tmpY = y - i * fonte.Height;

                if (MenuItens.Selecionado == i)
                    cor = Color.FromArgb(MenuItens.Itens[i].Enabled ? 255 : 153, Color.DodgerBlue);
                else
                    cor = Color.FromArgb(MenuItens.Itens[i].Enabled ? 255 : 153, Color.White);

                Fontes.DrawString(textoItem, fonte, cor, true, tmpX, tmpY);
            }
            #endregion
        }

        internal static void RenderJogo(int Tick, float Avanco)
        {
            Textura textura;
            Fonte fonte;
            SizeF TamFonte;
            float x, y, rot;

            if ((Blocos.SubEstadoJogo & Blocos.SubEstadosJogo.BAIRRO) == Blocos.SubEstadosJogo.BAIRRO)
            {
                int moradores = SaveGame.QtdeMoradores;

                ClearRadial(Color.White, Color.Gray, 30);

                #region Extras
                //Escreve Título da tela
                fonte = Fontes.GetFonte("Nome Menu");
                TamFonte = fonte.MedirTexto("Vista do Bairro");
                Fontes.DrawString("Vista do Bairro", fonte, Color.White, true, Screen.Width / 2 - TamFonte.Width / 2, Screen.Height - TamFonte.Height);
                //Desenha a quantidade de moradores
                fonte = Fontes.GetFonte("Outros24");
                TamFonte = fonte.MedirTexto(moradores.ToString());
                textura = Texturas.GetTextura("PopIco");

                Texturas.DrawTextura(textura, Screen.Width - TamFonte.Width * 0.7f - 64, Screen.Height - (textura.Height * 0.7f) / 2 - fonte.Height / 2, textura.Width * 0.7f, textura.Height * 0.7f, 0);
                Fontes.DrawString(moradores.ToString(), fonte, Color.White, true, Screen.Width - TamFonte.Width - 5, Screen.Height - TamFonte.Height);
                #endregion

                #region Desenha a Cidade
                textura = Texturas.GetTextura("Base Cidade");
                Gl.glColor3f(1, 1, 1);
                Texturas.DrawTextura(textura, Screen.Width / 2 - textura.Width / 2, Screen.Height / 2 - textura.Height / 2, textura.Width, textura.Height, 0);
                #endregion

                #region Desenha os IcoPredios
                if (Blocos.SubEstadoJogo == (Blocos.SubEstadosJogo.BAIRRO | Blocos.SubEstadosJogo.LIVRE))
                {
                    x = 40; y = Screen.Height / 2 + 75;

                    textura = Texturas.GetTextura("CurHand");
                    Gl.glColor3f(1, 1, 1);
                    Texturas.DrawTextura(textura, Math.Abs(10 - (Tick / 50 % 20)), y - textura.Height / 2 - 50 * ((int)Blocos.TipoPredioSelec - 1), textura.Width, textura.Height, 0);

                    textura = Texturas.GetTextura("IcoPredio Azul");
                    Texturas.DrawTextura(textura, x, y - textura.Height / 4, textura.Width / 2, textura.Height / 2, 0);
                    y -= 50;

                    textura = Texturas.GetTextura("IcoPredio Vermelho");
                    Gl.glColor4f(1, 1, 1, moradores >= 300 ? 1 : 0.5f);
                    Texturas.DrawTextura(textura, x, y - textura.Height / 4, textura.Width / 2, textura.Height / 2, 0);
                    y -= 50;

                    textura = Texturas.GetTextura("IcoPredio Verde");
                    Gl.glColor4f(1, 1, 1, moradores >= 1000 ? 1 : 0.5f);
                    Texturas.DrawTextura(textura, x, y - textura.Height / 4, textura.Width / 2, textura.Height / 2, 0);
                    y -= 50;

                    textura = Texturas.GetTextura("IcoPredio Amarelo");
                    Gl.glColor4f(1, 1, 1, moradores >= 3500 ? 1 : 0.5f);
                    Texturas.DrawTextura(textura, x, y - textura.Height / 4, textura.Width / 2, textura.Height / 2, 0);
                }
                #endregion
            }
            else if ((Blocos.SubEstadoJogo & Blocos.SubEstadosJogo.CONSTRUINDO) == Blocos.SubEstadosJogo.CONSTRUINDO)
            {
                Gl.glPushMatrix();

                #region Offset da Câmera
                {
                    float diferenca = 300 * Avanco;
                    float AltDesejada = Math.Max(0, Blocos.Andares.Count * 128 - 256);//(Screen.Height - Cursor.Position.Y - 1) * 10; //Controla a altura da câmera pelo mouse
                    //AltDesejada = (Screen.Height - Cursor.Position.Y - 1) * 10; //Controla a altura da câmera pelo mouse

                    if (Blocos.AlturaCamera != AltDesejada)
                    {
                        if (Math.Abs(Blocos.AlturaCamera - AltDesejada) < diferenca)
                            Blocos.AlturaCamera = AltDesejada;
                        else
                            Blocos.AlturaCamera += AltDesejada > Blocos.AlturaCamera ? diferenca : -diferenca;
                    }
                }

                Gl.glTranslatef(0, -Blocos.AlturaCamera, 0);
                #endregion

                #region Cor de Fundo e Estrelas
                //Cor de Fundo
                Gl.glBegin(Gl.GL_QUAD_STRIP);
                Gl.glColor3ub(240, 248, 255);
                Gl.glVertex2i(0, 0);
                Gl.glVertex2i(Screen.Width, 0);

                Gl.glColor3ub(60, 150, 255);
                Gl.glVertex2i(0, 1000);
                Gl.glVertex2i(Screen.Width, 1000);

                Gl.glColor3ub(0, 5, 17);
                Gl.glVertex2i(0, 3000);
                Gl.glVertex2i(Screen.Width, 3000);

                Gl.glVertex2i(0, 10000);
                Gl.glVertex2i(Screen.Width, 10000);
                Gl.glEnd();

                //Estrelas
                textura = Texturas.GetTextura("Estrela");
                foreach (Estrela estrela in Estrelas)
                {
                    if (estrela.y < (Blocos.AlturaCamera + Screen.Width) && estrela.y > Blocos.AlturaCamera)
                    {
                        Gl.glColor4f(1, 1, 1, estrela.Alpha);
                        Texturas.DrawTextura(textura, estrela.x - textura.Width / 2, estrela.y - textura.Height, textura.Width, textura.Height, 0);
                    }
                }
                #endregion

                #region Prédio Fundo, Grade, Árvores e o Avião
                Gl.glColor3f(1, 1, 1);

                textura = Texturas.GetTextura("Avião");
                Texturas.DrawTextura(textura, AviaoX - textura.Width / 2, 600 + Blocos.AlturaCamera / 2.5f, textura.Width, textura.Height, 0);

                if (AviaoX < -400)
                    AviaoX = Screen.Width + 400;
                AviaoX -= 100 * Avanco;

                textura = Texturas.GetTextura("Prédios Fundo");
                Texturas.DrawTextura(textura, Screen.Width / 2 - textura.Width / 2, Blocos.AlturaCamera / 2f, textura.Width, textura.Height, 0);

                textura = Texturas.GetTextura("Grade");
                for (int i = 0; i <= Screen.Width / textura.Width; i++)
                    Texturas.DrawTextura(textura, i * textura.Width, 0, textura.Width, textura.Height, 0);

                textura = Texturas.GetTextura("Árvore 1");
                Texturas.DrawTextura(textura, Screen.Width / 2 + 450 - textura.Width / 2, 0, textura.Width, textura.Height, 0);
                textura = Texturas.GetTextura("Árvore 2");
                Texturas.DrawTextura(textura, Screen.Width / 2 - 400 - textura.Width / 2, 0, textura.Width, textura.Height, 0);
                #endregion

                #region Chão
                Gl.glBegin(Gl.GL_QUADS);
                //Chão de terra
                Gl.glColor3ub(0x80, 0x60, 0);
                Gl.glVertex2i(0, 0);
                Gl.glVertex2i(Screen.Width, 0);
                Gl.glVertex2i(Screen.Width, 5);
                Gl.glVertex2i(0, 5);
                //Chão de Cimento Borda
                Gl.glColor3ub(0x60, 0x60, 0x60);
                Gl.glVertex2i(Screen.Width / 2 - 258, 0);
                Gl.glVertex2i(Screen.Width / 2 + 258, 0);
                Gl.glVertex2i(Screen.Width / 2 + 258, 12);
                Gl.glVertex2i(Screen.Width / 2 - 258, 12);
                //Chão de Cimento
                Gl.glColor3ub(0x80, 0x80, 0x80);
                Gl.glVertex2i(Screen.Width / 2 - 256, 0);
                Gl.glVertex2i(Screen.Width / 2 + 256, 0);
                Gl.glVertex2i(Screen.Width / 2 + 256, 10);
                Gl.glVertex2i(Screen.Width / 2 - 256, 10);
                Gl.glEnd();
                #endregion

                #region Guindaste
                //Cabo do Guindaste
                Blocos.Guindaste.ProgBalanco += (0.55f - ((Blocos.Guindaste.ProgBalanco > 0.5f ? Blocos.Guindaste.ProgBalanco : 1 - Blocos.Guindaste.ProgBalanco) - 0.5f)) * 2 * Avanco;
                rot = (Blocos.Guindaste.DirecDir ? 1f - Blocos.Guindaste.ProgBalanco : Blocos.Guindaste.ProgBalanco);
                x = Screen.Width / 2;
                y = Blocos.AlturaCamera + 3000;
                x -= 2400 * (float)Math.Cos((260 + 20 * rot) * (Math.PI / 180));
                y -= 2400 * -(float)Math.Sin((260 + 20 * rot) * (Math.PI / 180));

                Gl.glColor3f(0.1f, 0.1f, 0.1f);
                Gl.glLineWidth(3);
                Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(Screen.Width / 2, Blocos.AlturaCamera + 3000);
                Gl.glVertex2f(x, y);
                Gl.glEnd();

                //Andar preso ao guindaste
                if (Blocos.Guindaste.Andar != null)
                {
                    Blocos.Guindaste.Andar.Angulo = 10 - 20 * rot;
                    Blocos.Guindaste.Andar.Posicao = new PointF(x - 64, y - 128);
                }
                #endregion

                #region Andares
                Gl.glColor3f(1, 1, 1);
                bool TemAndarCaindo = false;
                List<Andar> LixeiraAndares = new List<Andar>();

                foreach (Andar andar in Blocos.Andares)
                {
                    #region Processa a queda
                    if (andar.Caindo)
                    {
                        TemAndarCaindo = true;
                        PointF Posicao = andar.Posicao;
                        RectangleF areaColisao;

                        if (andar.Angulo != 0)
                        {
                            float diferenca = Math.Abs(andar.Angulo);
                            float movimento = 10 * Avanco;

                            if (movimento > diferenca)
                                andar.Angulo = 0;
                            else
                                andar.Angulo += andar.Angulo > 0 ? -movimento : movimento;
                        }


                        if (Blocos.Andares.Count < 2) //Colide com o chão
                            areaColisao = new RectangleF(Screen.Width / 2 - 256, 10, 512, 0);
                        else //Colide com o ultimo andar
                        {
                            Andar UltimoAndar = Blocos.Andares[Blocos.Andares.Count - 2];
                            areaColisao = new RectangleF(UltimoAndar.Posicao.X, UltimoAndar.Posicao.Y + 128, 128, 0);
                        }


                        if (
                            Posicao.X + andar.VelX * Avanco >= areaColisao.X - 64 &&
                            Posicao.X + andar.VelX * Avanco <= areaColisao.X + areaColisao.Width - 64) //Verifica se esta na área de cosisão
                        {
                            if (Posicao.Y > areaColisao.Y && Posicao.Y + andar.VelY * Avanco <= areaColisao.Y) //Verifica se o movimento que o andar fez foi motivo de colisão
                            {
                                Posicao.Y = areaColisao.Y;
                                andar.Caindo = false;
                                andar.Angulo = 0;
                            }
                        }

                        Posicao.X += andar.VelX * Avanco;
                        if (andar.Caindo)
                        {
                            Posicao.Y += andar.VelY * Avanco;

                            if (Posicao.Y < Blocos.AlturaCamera - 512)
                                LixeiraAndares.Add(andar);
                        }
                        else //Se terminou de cair gera a fumaça
                        {
                            for (int i = 0; i <= 128; i += 16)
                            {
                                Fumacas.Add(new Fumaca(i - 16 + Posicao.X, Posicao.Y - 16, (float)rdn.NextDouble() * 360));
                                Fumacas.Add(new Fumaca(i - 16 + Posicao.X, Posicao.Y, (float)rdn.NextDouble() * 360));
                            }
                        }
                        andar.Posicao = Posicao;

                        andar.VelY -= 2000 * Avanco;
                    }
                    #endregion

                    #region Desenha
                    if (andar.Posicao.Y >= (Blocos.AlturaCamera - 128) &&
                        andar.Posicao.Y <= Blocos.AlturaCamera + Screen.Height)
                    {
                        if (andar.Angulo != 0) //Melhora o desempenho por que reduz o Nº de chamadas OpenGL
                        {
                            Gl.glPushMatrix();
                            Gl.glTranslatef(andar.Posicao.X + 64, andar.Posicao.Y + 128, 0);
                            Gl.glRotatef(andar.Angulo, 0, 0, 1);
                            Gl.glTranslatef(-(andar.Posicao.X + 64), -(andar.Posicao.Y + 128), 0);
                        }
                        Texturas.DrawTextura(andar.Textura, andar.Posicao.X, andar.Posicao.Y, 128, 128, 0);
                        if (andar.Angulo != 0)
                            Gl.glPopMatrix();
                    }
                    #endregion
                }

                //Deleta os Andares da lixera
                foreach (Andar andar in LixeiraAndares)
                {
                    Blocos.Andares.Remove(andar);
                    TemAndarCaindo = false;
                }

                //Repõe um andar no guindaste
                if (Blocos.Guindaste.Andar == null && !TemAndarCaindo)
                {
                    string parte = "Porta";
                    if (Blocos.Andares.Count > 0)
                        parte = "Janela";

                    Blocos.Guindaste.Andar = new Andar(0, 0, 0, Texturas.GetTextura(string.Format("Andar {0} {1}", Blocos.TipoPredioSelec.ToString(), parte)));
                    Blocos.Andares.Add(Blocos.Guindaste.Andar);
                }
                #endregion

                #region Fumacas
                List<Fumaca> LixeiraFumacas = new List<Fumaca>();
                textura = Texturas.GetTextura("Fumaça 1");

                foreach (Fumaca fumaca in Fumacas)
                {
                    Gl.glPushMatrix();
                    Gl.glTranslatef(fumaca.X + 16, fumaca.Y + 16, 0);
                    Gl.glScalef(1 + fumaca.Vida * 8, 1 + fumaca.Vida * 2, 0);
                    Gl.glTranslatef(-(fumaca.X + 16), -(fumaca.Y + 16), 0);

                    Gl.glColor4f(1, 1, 1, 1f - fumaca.Vida);
                    Texturas.DrawTextura(textura, fumaca.X, fumaca.Y, 32, 32, fumaca.Rotacao);

                    Gl.glPopMatrix();

                    fumaca.Y += 5 * Avanco;
                    fumaca.Rotacao -= 45 * Avanco;
                    fumaca.Vida += 0.5f * Avanco;
                    if (fumaca.Vida > 1)
                        LixeiraFumacas.Add(fumaca);
                }

                //Deleta as Fumacas da lixera
                foreach (Fumaca fumaca in LixeiraFumacas)
                    Fumacas.Remove(fumaca);
                #endregion

                Gl.glPopMatrix();
            }
        }

        static void ClearRadial(Color Centro, Color Borda, int Resolucao)
        {
            double Rad = Math.PI / 180,
                   Passo = 360f / Resolucao,
                   Raio = Math.Max(Screen.Width, Screen.Height) * 0.75;

            Gl.glBegin(Gl.GL_TRIANGLE_FAN);

            Gl.glColor4ub(Centro.R, Centro.G, Centro.B, Centro.A);
            Gl.glVertex2f(Screen.Width / 2f, Screen.Height / 2f);

            Gl.glColor4ub(Borda.R, Borda.G, Borda.B, Borda.A);
            for (int i = 0; i <= Resolucao; i++)
            {
                Gl.glVertex2f(Screen.Width / 2f + (float)(Math.Cos(i * Passo * Rad) * Raio),
                              Screen.Height / 2f + (float)(Math.Sin(i * Passo * Rad) * Raio));
            }

            Gl.glEnd();
        }
    }
}