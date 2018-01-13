using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;

namespace Endereco_IP
{
    public partial class FrmMain : Form
    {
        Stopwatch ContTempo = new Stopwatch();
        UTF8Encoding encoding = new UTF8Encoding();

        string[] NomePaises = { "Anonymous Proxy", "Satellite Provider", "Outro País", "Andorra", "Emirados Árabes Unidos", "Afeganistão", "Antigua e Barbuda", "Anguilla", "Albânia", "Armenia", "Angola", "Região Ásia / Pacífico", "Antarctica", "Argentina", "American Samoa", "Áustria", "Austrália", "Aruba", "Ilhas Aland", "Azerbaijão", "Bósnia e Herzegovina", "Barbados", "Bangladesh", "Bélgica", "Burkina Faso", "Bulgária", "Bahrain", "Burundi", "Benin", "Saint Bartelemey", "Bermuda", "Brunei Darussalam", "Bolívia", "Bonaire, Santo Eustáquio e Saba", "Brasil", "Bahamas", "Butão", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canadá", "Ilhas Cocos (Keeling)", "Congo, República Democrática do", "Central Africano República", "Congo", "Suíça", "Côte d'Ivoire ", "Ilhas Cook", "Chile", "Camarões", "China", "Colômbia ", "Costa Rica", "Cuba", "Cabo Verde", "Curaçao", "Christmas Island", "Chipre", "República Checa", "Alemanha", "Djibouti", "Dinamarca", "Dominica", " República Dominicana", "Argélia", "Equador", "Estónia", "Egito", "o Sahara Ocidental", "Eritreia", "Espanha", "Etiópia", "Europa", "Finlândia", "Fiji", "Ilhas Falkland (Malvinas)", "Micronésia, Estados Federados da", "Ilhas Faroe", "França", "Gabão", "Reino Unido", "Granada", "Georgia", "Guiana Francesa", "Guernsey ", "Gana", "Gibraltar", "Gronelândia", "Gâmbia", "Guiné", "Guadalupe", "Guiné Equatorial", "Grécia", "Geórgia do Sul e Sandwich do Sul", "Guatemala", "Guam", "Guiné-Bissau", "Guiana", "Hong Kong", "Ilha Heard e McDonald Ilhas", "Honduras", "Croácia", "Haiti", "Hungria", "Indonésia", "Irlanda", "Israel", "Ilha de Man", "Índia", "British Indian Ocean Territory", "Iraque", "o Irã, República Islâmica do", "A Islândia", "Itália", "Jersey", "Jamaica", "Jordan ", "Japão", "Quênia", "Quirguistão", "Camboja", "Kiribati", "Comores", "São Cristóvão e Nevis", "Coreia, República Popular Democrática da", "Coreia do Sul", "Kuwait", "Ilhas Cayman", "Cazaquistão", "Popular do Laos República Democrática", "Líbano", "Santa Lucia", "Liechtenstein", "Sri Lanka", "Libéria", "Lesoto", "Lituânia", "Luxemburgo", "Letónia", "Líbia", "Marrocos", "Monaco", "República da Moldávia", "Montenegro", "Saint Martin", "Madagascar", "Ilhas Marshall", "Macedónia", "Mali", "Myanmar", "Mongólia", "Macau", "Ilhas Marianas do Norte", "Martinica", "Mauritânia", "Montserrat", "Malta", "Maurício", "Maldivas", "Malawi", "México", "Malásia", "Moçambique", "Namíbia", "Nova Caledônia", "Niger", "Ilha Norfolk", "Nigéria", "Nicarágua", "Holanda", "Noruega", "Nepal", "Nauru", "Niue", "Nova Zelândia", "Omã", "Panama", "Peru", "Polinésia Francesa", "Papua Nova Guiné", "Filipinas", "Portugal", "Polônia", "Saint Pierre e Miquelon", "Pitcairn", "Puerto Rico", "Palestina", "Portugal", "Palau", "Paraguai", "Qatar", "Reunion", "Roménia", "Sérvia", "Rússia ", "Ruanda", "a Arábia Saudita", "Ilhas Salomão", "Seychelles", "Sudão", "Suécia", "Singapura", "Santa Helena", "Slovenia", "Ilhas Svalbard e Jan Mayen", "Eslováquia", "Serra Leoa", "San Marino", "Senegal", "Somália", "Suriname", "São Tomé e Príncipe", "El Salvador", "Sint Maarten", "República Árabe da Síria", "Suazilândia", "Ilhas Turks e Caicos", "Chad", "Territórios Franceses do Sul", "Togo", "Tailândia", "Tajiquistão", "Tokelau", "Timor-Leste", "o Turcomenistão", "Tunísia", "Tonga", "Turquia", "Trinidad e Tobago", "Tuvalu", "Formosa", "Tanzânia, República Unida da", "Ucrânia", "Uganda", "Estados Unidos Ilhas Menores Distantes", "Estados Unidos", "Uruguai", "Uzbequistão", "Santa Sé (Cidade do Vaticano)", "São Vicente e Granadinas", "Venezuela", "Ilhas Virgens Britânicas", "Ilhas Virgens, EUA", "Vietnã", "Vanuatu ", "Wallis e Futuna", "Samoa", "Yemen", "Mayotte", "África do Sul", "Zâmbia", "Zimbabwe" };
        string[] CodPaises = { "A1", "A2", "O1", "AD", "AE", "AF", "AG", "AI", "AL", "AM", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AW", "AX", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BL", "BM", "BN", "BO", "BQ", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CU", "CV", "CW", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "EU", "FI", "FJ", "FK", "FM", "FO", "FR", "GA", "GB", "GD", "GE", "GF", "GG", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IM", "IN", "IO", "IQ", "IR", "IS", "IT", "JE", "JM", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "ME", "MF", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RS", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "ST", "SV", "SX", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TL", "TM", "TN", "TO", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "ZA", "ZM", "ZW" };

        public FrmMain()
        {
            InitializeComponent();
        }

        void BtnLocalizar_Click(object sender, System.EventArgs e)
        {
            BtnLocalizar.Enabled = false;

            LblPais.Text = "...";
            LblCidade.Text = "...";

            ContTempo.Reset();
            ContTempo.Start();

            LocalizarIP(TxtIP.Text);
        }

        void PesquisaConcluida(Endereco endereco)
        {
            ContTempo.Stop();
            Text = string.Format("Concluído em {0:0.000} seg", ContTempo.Elapsed.TotalSeconds); //Dava 6 seg +/-

            BtnLocalizar.Enabled = true;
            if (endereco == null)
            {
                LblPais.Text = "?";
                LblCidade.Text = "?";
                return;
            }

            LblPais.Text = endereco.Pais;
            LblCidade.Text = endereco.Cidade == null ? "?" : endereco.Cidade;
        }

        uint GetNumIP(string IP)
        {
            uint NumIp;

            string[] sIP = IP.Split('.');
            NumIp = Convert.ToUInt32(sIP[0]) << 24;
            NumIp += Convert.ToUInt32(sIP[1]) << 16;
            NumIp += Convert.ToUInt32(sIP[2]) << 8;
            NumIp += Convert.ToUInt32(sIP[3]);

            return NumIp;
        }

        string getNomePaisPorCodPais(string CodPais)
        {
            for (int i = 0; i < NomePaises.Length; i++)
            {
                if (CodPaises[i] == CodPais)
                    return NomePaises[i];
            }

            return null;
        }

        void LocalizarIP(string IP)
        {
            Thread Th = new Thread(new ThreadStart(() =>
            {
                StreamReader Bd = null;
                Endereco endereco = null;

                try
                {
                    uint NumIp = GetNumIP(IP);
                    Bd = new StreamReader(Application.StartupPath + @"\BD\Blocos.csv");

                    while (!Bd.EndOfStream)
                    {
                        string[] dados = Bd.ReadLine().Replace("\"", "").Split(',');

                        try
                        {
                            if (NumIp >= Convert.ToUInt32(dados[0]) && NumIp <= Convert.ToUInt32(dados[1]))
                            {
                                endereco = GetEnderecoPorLocId(dados[2]);
                                break;
                            }
                        }
                        catch { }
                    }
                }
                catch { }
                finally
                {
                    if (Bd != null)
                    {
                        Bd.Close();
                        Bd.Dispose();
                    }
                }

                Invoke((MethodInvoker)delegate { PesquisaConcluida(endereco); });
            }));

            Th.IsBackground = true;
            Th.Priority = ThreadPriority.Lowest;
            Th.Start();
        }

        Endereco GetEnderecoPorLocId(string LocId)
        {
            StreamReader Bd = null;
            Endereco endereco = null;

            try
            {
                Bd = new StreamReader(Application.StartupPath + @"\BD\Dados-Locais.csv");

                while (!Bd.EndOfStream)
                {
                    string[] dados = Bd.ReadLine().Replace("\"", "").Split(',');

                    if (LocId == dados[0])
                    {
                        endereco = new Endereco(getNomePaisPorCodPais(dados[1]), dados[2], dados[3]);
                        Bd.Close();
                        Bd.Dispose();
                        return endereco;
                    }
                }
            }
            catch { }
            finally
            {
                if (Bd != null)
                {
                    Bd.Close();
                    Bd.Dispose();
                }
            }

            return null;
        }
    }
}