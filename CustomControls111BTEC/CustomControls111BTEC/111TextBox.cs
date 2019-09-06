using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls111BTEC
{
    public partial class _111TextBox : UserControl
    {
        private string placeHolderText = "Texto";
        private bool enablePlaceHolder=true;
        public _111TextBox()
        {
            InitializeComponent();
            textHolderLabel.Text = placeHolderText;
            textHolderLabel.BackColor = textBox1.BackColor = this.BackColor ;
        }

        //Creamos la propiedades del user control
        #region Propiedades
        /// <summary>
        /// Agregas el texto del PlaceHolder
        /// </summary>
        [Description("Texto de PlaceHolder"), Category("Style")]
        public string PalceHolderText
        {
            get { return this.placeHolderText; }
            set
            {
                textHolderLabel.Text = value;
                this.placeHolderText = value;
      
            }
        }
        /// <summary>
        /// Bandera para habilitar y deshabilitar el place holder
        /// </summary>
        [Description("Habilitar/Deshabilitar PlaceHolder"), Category("Style")]
        public bool EnablePalceHolder
        {
            get { return enablePlaceHolder; }
            set
            {
                if (textHolderLabel.Visible == true)
                {
                    textHolderLabel.Visible = value;
                    enablePlaceHolder = value;
                }
                    
                else
                {
                    enablePlaceHolder = value;
                }
            }
        }

        [Description("Habilitar/Deshabilitar PlaceHolder"), Category("Style")]
        public int BorderRadius
        {
            get { return bunifuElipse1.ElipseRadius; }
            set { bunifuElipse1.ElipseRadius = value; }
        }
        /// <summary>
        /// Color del texto del place holder
        /// </summary>
        [Description("PlaceHolder Color"), Category("Style")]
        public Color PlaceHolderColor
        {
            get { return textHolderLabel.ForeColor; }
            set { textHolderLabel.ForeColor = value; }
        }

        /// <summary>
        /// Alineación de PlaceHolder y TextBox
        /// </summary>
        [Description("Alinación de texto"), Category("Style")]
        public ContentAlignment TextAling
        {
            get { return textHolderLabel.TextAlign; }
            set
            {
                textHolderLabel.TextAlign = value; 
                //Aplicamos el fitro para alineaciones de label para textbox, porque no son del mismo tipo las alineaciones
                #region Alineación TextBox 
                switch (value)
                {
                    //Alinaecion al centro
                    #region Centro
                    case ContentAlignment.BottomCenter:
                        textBox1.TextAlign = HorizontalAlignment.Center;
                        break;
                    case ContentAlignment.MiddleCenter:
                        textBox1.TextAlign = HorizontalAlignment.Center;
                        break;
                    case ContentAlignment.TopCenter:
                        textBox1.TextAlign = HorizontalAlignment.Center;
                        break;
                    #endregion
                    //Alinaecion al Izquierda
                    #region Izquierda
                    case ContentAlignment.BottomLeft:
                        textBox1.TextAlign = HorizontalAlignment.Left;
                        break;
                    case ContentAlignment.MiddleLeft:
                        textBox1.TextAlign = HorizontalAlignment.Left;
                        break;
                    case ContentAlignment.TopLeft:
                        textBox1.TextAlign = HorizontalAlignment.Left;
                        break;
                    #endregion
                    //Alinaecion al Derecha
                    #region Derecha
                    case ContentAlignment.BottomRight:
                        textBox1.TextAlign = HorizontalAlignment.Right;
                        break;
                    case ContentAlignment.MiddleRight:
                        textBox1.TextAlign = HorizontalAlignment.Right;
                        break;
                    case ContentAlignment.TopRight:
                        textBox1.TextAlign = HorizontalAlignment.Right;
                        break;
                        #endregion
                }
                #endregion    
            }
        }
        
        [Description("Establece el TextBox como contraseña"), Category("Style")]
        public bool isPassword
        {
            get { return textBox1.UseSystemPasswordChar; }
            set
            {
                if (value)
                {//Asignamos el caracter con que se mostrara la contraseña

                    textBox1.UseSystemPasswordChar = true && enablePlaceHolder;
                    textBox1.PasswordChar = '•';
                }
                else
                {

                    textBox1.UseSystemPasswordChar = false;
                    
                }
            }
        }
        [Description("Obtiene y asigna el texto del textBox"), Category("Style")]
        
        public override string Text
        {  
            get { return textBox1.Text; }
            set
            {
                //Cuando el texto es "" Mostramos nuevamente el TextHolder
                if(value=="")
                {
                    textBox1.Text = value;
                    textHolderLabel.Visible = true;
                }
                else
                {
                    textBox1.Text = value;
                    textHolderLabel.Visible = false;
                }
                
            }
        }
        [Description("Habilita la propiedad multilinea al textbox"), Category("Style")]
        public bool isMultiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value;}
        }



        #endregion

        //Cramos los Eventos del User Control
        #region Eventos
        //Creamos el evento KeyDown
        public new event KeyPressEventHandler KeyPress
        {
            add { textBox1.KeyPress += value; }
            remove { textBox1.KeyPress -= value; }
        }
        //Creamos el evento KeyDown
        public new event KeyEventHandler KeyDown
        {
            add { textBox1.KeyDown += value; }
            remove { textBox1.KeyDown -= value; }
        }
        #endregion

        //Funcionalidades Internas
        #region Funcionalidades
        private void _111TextBox_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textHolderLabel.Visible = true && enablePlaceHolder;
                textHolderLabel.Text = placeHolderText;
            }

        }

        private void _111TextBox_Enter(object sender, EventArgs e)
        {
            textHolderLabel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textHolderLabel.Visible = false;
            textBox1.Focus();
            _111TextBox_Enter(sender, e);
        }

        private void _111TextBox_ForeColorChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = this.ForeColor;
        }

        private void _111TextBox_BackColorChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = this.BackColor;
            textHolderLabel.BackColor = this.BackColor;

        }
        #endregion


    }
}
