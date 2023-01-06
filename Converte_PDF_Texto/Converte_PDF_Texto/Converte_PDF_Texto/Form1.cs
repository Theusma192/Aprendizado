using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Converte_PDF_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertePDF_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertePDF pdftxt = new ConvertePDF();
                txtArquivoTexto.Text = pdftxt.ExtrairTexto_PDF(txtCaminoNomePDF.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = false;
            this.ofd1.Title = "Selecionar PDF";
            ofd1.InitialDirectory = @"C:\dados";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Files (*.PDF)|*.PDF|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = false;
            
            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                txtCaminoNomePDF.Text = ofd1.FileName;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //verifica se existe algo digitado na caixa de texto
            if (string.IsNullOrEmpty(txtArquivoTexto.Text))
            {
                MessageBox.Show("Informe algo na caixa de texto");
                return;
            }

            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo Texto";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "Text File|.txt";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Inteiro Teor" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
            //Define a extensão padrão como .txt
            saveFileDialog1.DefaultExt = ".txt";
            //define o diretório padrão
            saveFileDialog1.InitialDirectory = @"c:\dados";
            //restauro o diretorio atual antes de fechar a janela
            saveFileDialog1.RestoreDirectory = true;
            //exibe um aviso se o usuário informar um arquivo que não existe
            //saveFileDialog1.CheckFileExists = true;
            //exibe um aviso se o usuário informar um caminho que não existe
            saveFileDialog1.CheckPathExists = true;

            //Open the dialog and determine which button was pressed
            DialogResult resultado = saveFileDialog1.ShowDialog();

            //Se o ousuário pressionar o botão Salvar
            if (resultado == DialogResult.OK)
            {
                //Cria um stream usando o nome do arquivo
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);

                //Cria um escrito que irá escrever no stream
                StreamWriter writer = new StreamWriter(fs);
                //escreve o conteúdo da caixa de texto no stream
                writer.Write(txtArquivoTexto.Text);
                //fecha o escrito e o stream
                writer.Close();
            }
            else
            {
                //exibe mensagem informando que a operação foi cancelada
                MessageBox.Show("Operação cancelada");
            }
        }
    }
}
