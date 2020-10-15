using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_basura_293289328_ce_sharp
{

    public partial class Form1 : Form
    {
        string[] nombres = new string[] { "jorge", "carol", "mario", "geraldo", "tam", "cesar", "boby" };
        int[] minumero = new int[] { 1, 1, 1 };
        int[] elnumero = new int[] { 1, 1, 1 };
        int puntos = 0;
        byte cupon = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sistema para ganar listo
Random rand = new Random();
int random = rand.Next(0, 50);
            if (minumero[0] == elnumero[0] && minumero[1] == elnumero[1] && minumero[2] == elnumero[2])
                
            {

                MessageBox.Show("ganaste te odio", "ia: pinche ganador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                elnumero[0] = random;
                elnumero[1] = random;
                elnumero[2] = random;
                puntos = +10;
                MessageBox.Show("ia esta super enojado y sobrescribio los numeros:" + elnumero[0], "ia se venga grgrgrgg", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if(minumero[0] == elnumero[0] && minumero[1] == elnumero[1] || minumero[2] == elnumero[2] && minumero[1] == elnumero[1])
            {
                MessageBox.Show("No eres tan bueno no le latinaste los tres", "ia preocupado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                puntos = puntos + 6;
                elnumero[0] = random;
                elnumero[1] = random;
                elnumero[2] = random;
            }
            else if(minumero[0] == elnumero[0] && minumero[2] == elnumero[2])
            {
              MessageBox.Show("solo le atinaste en el 1 a 3 ke importa si no sabes que digo eres losee 80%", "ia normal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                puntos = puntos +3;
                elnumero[0] = random;
                elnumero[1] = random;
                elnumero[2] = random;
            } else if(minumero[0] == elnumero[0] || minumero[1] == elnumero[1] || minumero[2] == elnumero[2])
            {
                MessageBox.Show("jajajaj solo 1 ??????? ", "ia feliz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                puntos = puntos +1;
                elnumero[0] = random;
                elnumero[1] = random;
                elnumero[2] = random;
            } else
            {
                MessageBox.Show("Eres perdedor numero 1 ni le latinaste niguno JA GANEEE", "ia contento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //radio troll listo
            radioButton1.Text = "jaj te engañe";
            MessageBox.Show("jaj te engañamos y aora se sobrescibio tu numero jajajaja");
            minumero[1] = -1212;
            minumero[2] = -7263;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // texto listo
            label1.Text = "tu numero:" + minumero[0] + " " + minumero[1] + " " + minumero[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //este boton esta casi listo busqueda
            Random rand = new Random();
            int random = rand.Next(0, 6);
            int random2 = rand.Next(0, 6);
           
            if(random > 4 || cupon > 1)
            {
                MessageBox.Show("Quiere batayar contigo: " + nombres[random2] , "miraaaaa" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
                int vida = 5;
                int suvida = 5;
                int eleccion = rand.Next(1,3);
                int mieleccion = 0;
                bool terminar = true;

                string[] ataques = new string[] {"vacio no deberias verme creo", "abortar", "retirar", "ingnorar" };
                while (terminar)
                {
                    switch (MessageBox.Show("elige pa atacar", "jwjsw", MessageBoxButtons.AbortRetryIgnore))

                    {
                        case (DialogResult.Abort):
                            MessageBox.Show("usas abortar bebes okno abortar");
                            mieleccion = 1;

                            break;
                        case (DialogResult.Retry):
                            MessageBox.Show("usas defensa jaj");
                            mieleccion = 2;
                            break;
                        case (DialogResult.Ignore):
                            MessageBox.Show("usas ingnorar? eres medioso o k");
                            mieleccion = 3;
                            break;
                    }
                    MessageBox.Show(nombres[random2] + " uso " + ataques[eleccion]);
                    if (mieleccion != eleccion)
                    {
                        MessageBox.Show("le kitas vida!");
                        suvida--;
                    }
                    else
                    {
                        MessageBox.Show("te ataco y tu atace menso no sirvo pa nada");
                        vida--;
                    }

                    if (vida == 0)
                    {
                        MessageBox.Show("Perdiste jajaj", "jajaajajajja");
                        terminar = false;
                    }
                    else if (suvida == 0)
                    {
                        MessageBox.Show("ganasteee aora se sobrescribira tu numeor");
                       
                        switch(MessageBox.Show("Elige: si es izquierda y derecha es no. o si el tipo te dio numero malo pues cancela" , nombres[random] , MessageBoxButtons.YesNoCancel))
                        {
                            case (DialogResult.Yes):
                                minumero[1] = elnumero[1];
                                minumero[0] = elnumero[0];
                                MessageBox.Show("se sobrescibrio ecitosamente jeje");
                                break;
                            case (DialogResult.No):
                                minumero[1] = elnumero[1];
                                minumero[2] = elnumero[2];
                                MessageBox.Show("se sobrescribio ecitosamente ejeje");
                                break;
                            case (DialogResult.Cancel):
                                MessageBox.Show("que mal :(");
                                break;
                        }
                        terminar = false;
                    }
                    eleccion = rand.Next(1, 3);
                }

            } else
            {
                MessageBox.Show("A nadie le interesa a ti we");
            }
          
            if(cupon > 1)
            {
                cupon--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //este boton esta listo numeros gratis
            bool testO = true;
            int test = 6;
            if(test > 3)
            {
                MessageBox.Show("error okno bay");
            } else
            {
                MessageBox.Show("tetetetst");
            }
            for(int i = 0; i < 3;i++)
            {
            switch(MessageBox.Show("clickeame we" , "for test" , MessageBoxButtons.YesNo))
                {
                    case (DialogResult.Yes):

                        break;
                    case (DialogResult.No):

                        break;
                }
            }
            MessageBox.Show("espera...........");
            while(testO)
            {
                switch(MessageBox.Show("eres gei?????" , "gey test en español" , MessageBoxButtons.YesNo))
                {
                    case (DialogResult.Yes):
                        MessageBox.Show("jajaj gei");
                        testO = false;
                        break;
                    case (DialogResult.No):
                        MessageBox.Show("si lo eres", "admutelo");
                        break;
                }
            }
            MessageBox.Show("bueeeeno ya te dare tu numero culero bay", "ia enojado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            minumero[1] = elnumero[1];
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //intercambio listo
            Random rand = new Random();
            int random = rand.Next(1, 6);
            int nombre = rand.Next(0, 6);
            if(random >4 || cupon > 1)
            {

               // int minumeroAlterado = rand.Next(elnumero[0], 50);
               
                int minumeroAlterado;
                if(elnumero[0] > 45)
                {
                    minumeroAlterado = elnumero[0];
                } else
                {
                    
                    int sumar = rand.Next(0, 5);
                    minumeroAlterado = elnumero[0] + sumar;
                }

                switch (MessageBox.Show(nombres[nombre] + " quiere intercambiarte " + minumeroAlterado + " aceptass???????", "a alguen le interesa uouoo", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    case (DialogResult.Yes):
                        int elegir = rand.Next(0, 2);
                        switch(elegir)
                        {
                            case (0):
                                minumero[0] = minumeroAlterado;
                                break;
                            case (1):
                                minumero[1] = minumeroAlterado;
                                break;
                            case (2):
                                minumero[2] = minumeroAlterado;
                                break;
                        }
                        MessageBox.Show("numero escrito esitosamente wiwiwieieiw", "wi aowjswjdjwedi");
                        break;
                    case (DialogResult.No):
                        MessageBox.Show("ok bomer");
                        break;
                }
            } else
            {
                MessageBox.Show("No se encontro nadie. Quizas eres feo o prieto o amargado", "Error grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(cupon > 1)
            {
                cupon--;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
        // loteria san jose listo
            MessageBox.Show("bienvenidoh a h loteria san joose ai ganas numeros u puntos y esas chacharas", "loyteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Random rand = new Random();
            int random = rand.Next(1, 50);
            switch(MessageBox.Show("tienes numeroo: " + random + "loquieres berdad o no?" , "lote dice" ,MessageBoxButtons.YesNo , MessageBoxIcon.Exclamation))
            {
                case (DialogResult.Yes):
                    MessageBox.Show("oka");
                    break;
                case (DialogResult.No):
                    MessageBox.Show("como que no pendejo");
                    break;

                    
            }
            if(random > 40)
            {
                MessageBox.Show("eroabuena ganaste un numero gratis!!", "wiii");
                int elegir = rand.Next(0, 2);
                switch (elegir)
                {
                    case (0):
                        minumero[0] = elnumero[0];
                        break;
                    case (1):
                        minumero[1] = elnumero[1];
                        break;
                    case (2):
                        minumero[2] = elnumero[2];
                        break;
                }
                MessageBox.Show("sobrescribido ecitocamente");
            } else if(random > 30)
            {
                MessageBox.Show("eruabuena ganaste 1 puntoo");
                puntos = puntos +1;
            } else if(random > 20)
            {
                MessageBox.Show("eroabuena ganaste +2 a tu numeros!");
                int elegir = rand.Next(0, 2);
                switch (elegir)
                {
                    case (0):
                        minumero[0] = minumero[0] +2;
                        break;
                    case (1):
                        minumero[1] = minumero[1] +2;
                        break;
                    case (2):
                        minumero[2] = minumero[2] +2;
                        break;
                }
            } else if(random > 10)
            {
                MessageBox.Show("eroabuena ganaste un tecto bonito");
                MessageBox.Show("Eres el mas guapo y el mejor te sonrio porque tu voz me ase feliz TE QUIERO (el singo ? es un corazon para ti <3)", "texto gratis", MessageBoxButtons.OK, MessageBoxIcon.Question);
            } else
            {
                MessageBox.Show("Eres un perdedor y perdiste asique doble perdedor ajjaajjaja");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cupones
            MessageBox.Show("Bienvenido a cupones maria Los cupones sirven para atraer la gente imediatamente sirve para busqueda y intercambio", "cuponaje store", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(puntos > 3)
            {
              switch ( MessageBox.Show("un cupon suerte vale 3 puntos kieres?" , "Cupones" , MessageBoxButtons.YesNo , MessageBoxIcon.Question))
                {
                    case (DialogResult.Yes):
                        puntos = puntos -3;
                        cupon++;
                        MessageBox.Show("fue gusto aser negocios");
                        break;
                    case (DialogResult.No):
                        MessageBox.Show("Ok regresaras verdad ekjejeje");
                        break;
                }
            } else
            {
                MessageBox.Show("regresa cuando tengas 3 puntos", "Pobreee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = minumero[0] + " " + minumero[1] + " " + minumero[2];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //venta de numeros
            Random rand = new Random();
            switch(MessageBox.Show("Te gustaria vender tu numero?" , "Pregunta seria" , MessageBoxButtons.YesNo , MessageBoxIcon.Question))
            {
                case (DialogResult.Yes):
                    int random = rand.Next(1,6);
                    if(random > 3)
                    {
                        int numero = rand.Next(0, 2);
                        int puntosDeVenta = rand.Next(0, 5);

                    switch( MessageBox.Show(nombres[random] + " quiere comprar tu numero " + minumero[numero] + " a cambio de: " + puntosDeVenta , "kieres we?" , MessageBoxButtons.YesNo , MessageBoxIcon.Information))
                        {
                            case (DialogResult.Yes):
                                puntos = puntos + puntosDeVenta;
                                minumero[numero] = 0;
                                MessageBox.Show("ecito gracias por aser bentas", nombres[random]);
                                break;
                            case (DialogResult.No):
                                MessageBox.Show("Te lo pierdes");
                                break;
                        }
                    } else
                    {
                        MessageBox.Show("Parece que tus numeros son culeros", "error jajjaja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case (DialogResult.No):
                    MessageBox.Show("Porque noo ganaras muchoos puntos uwu", ":(");
                    break;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //puntos visisble
            linkLabel3.Text = puntos.ToString();
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.Text = elnumero[0] + " " + elnumero[1] + " " + elnumero[2];
        }
         int oportunidad = 5;
        private void button9_Click(object sender, EventArgs e)
        {
           
            if (oportunidad < 1)
            {
                MessageBox.Show("Ya no mas");
            } else
            {
                oportunidad--;
                minumero[0]++;
                minumero[1]++;
                minumero[2]++;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (oportunidad > 5)
            {
                MessageBox.Show("Ya no mas");
            }
            else
            {
                oportunidad++;
                minumero[0]--;
                minumero[1]--;
                minumero[2]--;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //mafia rodrigo
            MessageBox.Show("Bienvenido a mafia rodrigo un pack de 4 utiles herramientas y super importante un numero gratis!!! Sepa que numero tiene y el de rival y suma unos 5 veses o resta su numero!! Todo por 30 puntos", "mafia rodrigo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (puntos > 30)
            {
                switch(MessageBox.Show("Comprar el pack mafia rodrigo costara 30 puntos te animas? asegurate de si clickeaste el boton numeros gratis" , "mafia bros okno" , MessageBoxButtons.YesNo ,MessageBoxIcon.Information))
                {
                    case (DialogResult.Yes):
                        puntos = puntos - 30;
                        linkLabel1.Enabled = true;
                        linkLabel2.Enabled = true;
                        button9.Enabled = true;
                        button10.Enabled = true;

                        button3.Enabled = true;

                        MessageBox.Show("placer aser negocios!");
                        button8.Enabled = false;
                        break;
                    case (DialogResult.No):
                        MessageBox.Show("ok :C");
                        break;
                }
            } else
            {
                MessageBox.Show("Vuelve cuando tengas 30 puntos", "re pobree");
            }
        }
    }
}
