using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class frmJogoDaForca : Form
    {
        private String[] palavras; //Vetor que armazenará as palavras do jogo
        private String[] dicas; //Dicas relacionadas as palavras em questão
        private String palavraAtual; //Palavra que o usuário vai identificar
        private String tela = ""; //Essa variável vai armazenar o texto do 1º textBox
        private String numeros = "0123456789"; 
        private int tentativas; //Variável dos erros
        private int posPalavra; //Escolhe a palavra

        public frmJogoDaForca()
        {
            //Método Construtor
            InitializeComponent(); //Começa o jogo
            this.IniciaVetor(); //Cria os dois vetores
            txbPalavra.Text = ""; //Zera o valor da palavra
        }

        private void IniciaVetor()
        {
            //Método que cria os vetores e os atribui palavras
            palavras = new String[10];
            dicas = new String[10];

            palavras[0] = "cachorro";
            dicas[0] = "Animal doméstico";

            palavras[1] = "guepardo";
            dicas[1] = "Felino selvagem";

            palavras[2] = "liquidificador";
            dicas[2] = "Eletrodoméstico";

            palavras[3] = "engenheiro";
            dicas[3] = "Quem se forma em engenharia é...";

            palavras[4] = "poliglota";
            dicas[4] = "Fala muitas línguas";

            palavras[5] = "mercúrio";
            dicas[5] = "Planeta mais próximo do sol";

            palavras[6] = "bitcoin";
            dicas[6] = "Criptomoeda muito famosa";

            palavras[7] = "atlântico";
            dicas[7] = "Oceano que banha a costa do Brasil";

            palavras[8] = "microsoft";
            dicas[8] = "Empresa que criou o Windows";

            palavras[9] = "hulk";
            dicas[9] = "Conhecido como \"Gigante Esmeralda\"";
        }

        private void btnGerarPalavra_Click(object sender, EventArgs e)
        {
            lbDica.Visible = false; //Não mostra a dica

            //Gera a palavra que será adivinhada
            Random r = new Random();
            posPalavra = r.Next(0, 10); //Escolhe randomicamente entre as 9 palavras do vetor
            palavraAtual = palavras[posPalavra]; //Insere a palavra escolhida no vetor
            tela = ""; //Zera o valor da tela
            for (int i = 0; i < palavraAtual.Length; i++) //Insere a palavra e a esconde com "%"
            {
                tela += "*"; //Coloca * nas letras para esconder
            }
            txbPalavra.Text = tela; //Insere a palavra na tela

            lbDica.Text = dicas[posPalavra]; //Insere a dica correspondente da palavra
            btnDica.Visible = true; //Habilita o botão para ser apertado

            txbLetra.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Implementação do evento
            pnJogo.Visible = true;
            btnStart.Visible = false; //Ao clicar no "Start" será exibido o painel para selecionar a palavra para identificar
            txbPalavra.Text = ""; //Zera o valor da palavra a ser descoberta
            lbDica.Text = ""; //Zera o valor da dica anterior
            txbLetrasDg.Text = ""; //Zera o valor das letras digitadas

            //Total de tentativas
            tentativas = 6; //Até 6 erros são permitidos
            txbLetrasDg.Text = ""; //Zera o valor
            pcbForca.Visible = true; //Deixa a forca aparecer
            pcbBonecoCabeca.Visible = false; // Fotos da forca
            pcbBonecoCorp.Visible = false; // Fotos da forca
            pcbBonecoMao.Visible = false; // Fotos da forca
            pcbBonecoCorpo.Visible = false; // Fotos da forca
            pcbBonecoPe.Visible = false; // Fotos da forca
            pcbBonecoCompleto.Visible = false; // Fotos da forca

            btnPararMusica.Visible = true; //Mostra o botão de parar a música
            btnVoltarMusica.Visible = true; //Mostra o botão de voltar a música
            btnRegras.Visible = true;
            //Tocar música de fundo:
            SoundPlayer fundo = new SoundPlayer("PerituneMaterial_Sakuya2.wav");
            fundo.Load();
            fundo.PlayLooping();

            pcbGameOver.Visible = false;
            pcbWin.Visible = false;
            pnMsg.Visible = false;

            tela = ""; //Zera o valor da tela

            frmRegras frmRegras = new frmRegras(); //Abre a janela de regras
            frmRegras.ShowDialog();
        }

        //Para a música
        private void btnPararMusica_Click(object sender, EventArgs e)
        {
            SoundPlayer fundo = new SoundPlayer("PerituneMaterial_Sakuya2.wav");
            fundo.Stop();
        }

        //Volta a música
        private void btnVoltarMusica_Click(object sender, EventArgs e)
        {
            SoundPlayer fundo = new SoundPlayer("PerituneMaterial_Sakuya2.wav");
            fundo.Load();
            fundo.PlayLooping();
        }

        private void btnDica_Click(object sender, EventArgs e)
        {
            //Verifica se há palavra para colocar dica
            if (tela == "" && lbDica.Visible == false)
            {
                MessageBox.Show("Não há palavra");
            }
            else
            {
                lbDica.Visible = true; //Mostra a dica
                btnDica.Visible = false;
            }

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            Boolean encontrar = false; //Variável para verificar se achou a palavra
            Char letra = ' '; //Variável da letra digitada

            //Verifica se a entrada é nula ou um número
            try
            {
                letra = Convert.ToChar(txbLetra.Text.ToUpper().ToLower()); //converte a string para char
            }
            catch
            {
                MessageBox.Show("Insira um caractere válido");
                txbLetrasDg.Text = ""; //Limpa a caixa de letras digitadas
                return;
            }
            if (numeros.IndexOf(letra) >= 0 || letra == ' ') 
            {
                MessageBox.Show("Insira um caractere válido");
                txbLetrasDg.Text = ""; //Limpa a caixa de letras digitadas
                tentativas++; //Não decrementa o erro
            }
            //Verifica se a letra já foi digitada
            if (txbLetrasDg.Text == $"{letra}")
            {
                MessageBox.Show("Você já digitou essa letra");
            }


            //Letras Digitadas:
            if (txbLetrasDg.Text.Length <= 0)
            {
                txbLetrasDg.Text += txbLetra.Text;//Adiciona a primeira letra digitada
            }

            else
            {
                txbLetrasDg.Text += ", " + txbLetra.Text; //Adiciona a letra digitada mais uma vírgula
            }

            //Verificar se já digitou uma letra:
            for (int i = 0; i < txbLetrasDg.Text.Length - 1; i++)  //Varre as letras já digitadas em busca da letra selecionada
            {
                if (txbLetrasDg.Text[i] == letra)
                {
                    MessageBox.Show("Você já digitou essa letra");
                }
            }

            //Atualiza a tela:
            //Verifica se a tela está vazia:
            if (tela == "")
            {
                MessageBox.Show("Não há palavra");
                txbLetra.Text = "";

            }
            //Se não estiver:
            else
            {
                //Verifica o resto:
                String texto = "";
                for (int i = 0; i < palavraAtual.Length; i++)  //Varre a palavra em busca da letra selecionada
                {
                    if (palavraAtual[i] == letra)
                    {
                        encontrar = true;
                        texto += txbLetra.Text.ToUpper().ToLower();  //Atualiza o texto na tela
                    }

                    else
                    {
                        texto += tela[i]; //Retoma o valor da tela 
                    }
                }

                txbLetra.Clear(); //Limpa o textbox da palavra
                tela = texto; //Atualiza o valor de tela para o valor do texto escrito
                txbPalavra.Text = tela;

                if (encontrar == false) //Decrementa o erro se não encontrar a letra
                {
                    tentativas--;//diminui os erros
                    //Atualiza a foto da forca comparado aos erros
                    if (tentativas == 5)
                    {
                        pcbForca.Visible = false; 
                        pcbBonecoCabeca.Visible = true;
                    }
                    else if (tentativas == 4)
                    {
                        pcbBonecoCabeca.Visible = false;
                        pcbBonecoCorp.Visible = true;
                    }
                    else if (tentativas == 3)
                    {
                        pcbBonecoCorp.Visible = false;
                        pcbBonecoMao.Visible = true;
                    }
                    else if (tentativas == 2)
                    {
                        pcbBonecoMao.Visible = false;
                        pcbBonecoCorpo.Visible = true;
                    }
                    else if (tentativas == 1)
                    {
                        pcbBonecoCorpo.Visible = false;
                        pcbBonecoPe.Visible = true;
                    }
                }

                //Se Perder:
                if (tentativas <= 0) //Caso ele exceda todos os erros
                {
                    pcbForca.Visible = false;
                    pcbBonecoCabeca.Visible = false;
                    pcbBonecoCorp.Visible = false;
                    pcbBonecoMao.Visible = false;
                    pcbBonecoCorpo.Visible = false;
                    pcbBonecoPe.Visible = false;
                    pcbBonecoCompleto.Visible = true;


                    pnJogo.Visible = false;
                    pnMsg.Visible = true;
                    pcbGameOver.Visible = true;
                    pcbWin.Visible = false;
                    btnStart.Visible = true;

                    btnPararMusica.Visible = false;
                    btnVoltarMusica.Visible = false;

                    //Tocar música de derrota:
                    SoundPlayer derrota = new SoundPlayer("mixkit-ominous-drums-227.wav");
                    derrota.Load();
                    derrota.Play();

                    btnRegras.Visible = false;
                }

                //Se Ganhar:
                else if (txbPalavra.Text.IndexOf('*') == -1)  //Caso ele acerte a palavra
                {
                    pnJogo.Visible = false;
                    pnMsg.Visible = true;
                    pcbWin.Visible = true;
                    pcbGameOver.Visible = false;
                    btnStart.Visible = true;

                    btnPararMusica.Visible = false;
                    btnVoltarMusica.Visible = false;

                    //Tocar música de vitória:
                    SoundPlayer vitoria = new SoundPlayer("mixkit-unlock-game-notification-253.wav");
                    vitoria.Load();
                    vitoria.Play();

                    btnRegras.Visible = false;
                }
            }
        }

        private void txbLetra_KeyUp(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                btnVerificar.PerformClick(); //Checa se o botão foi pressionado
            }
        }

        private void btnRegras_Click(object sender, EventArgs e)
        {
            frmRegras frmRegras = new frmRegras(); //Abre a janela de regras
            frmRegras.ShowDialog();
        }
    }
}
