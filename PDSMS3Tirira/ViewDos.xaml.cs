using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDSMS3Tirira
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewDos : ContentPage
    {
        double parcialDos;
        double notaSeguiDos;
        double notaExDos;

        double notaSeguiUno;
        double notaExUno;
        double parcialUno;

        double notaFinal;
        public ViewDos(string usuario, string clave)
        {
            InitializeComponent();
            //Envio a los label
            lblUsuario.Text = usuario;
            //Envio a las cajas de texto
            //txtUsuario.Text = usuario;
        }

        private void txtNotaSeguiUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                notaSeguiUno = Convert.ToDouble(txtNotaSeguiUno.Text);

                //aceptar valores de 1-10
                if (notaSeguiUno < 0)
                {
                    DisplayAlert("MENSAJE DE ALERTA", "No se permite valores menores de 0", "OK");
                    txtNotaSeguiUno.Text = "";
                }
                else
                {
                    if (notaSeguiUno > 10)
                    {
                        DisplayAlert("MENSAJE DE ALERTA", "No se permite valores mayores de 10", "OK");
                        txtNotaSeguiUno.Text = "";
                    }
                }


            }
            catch (Exception ex)
            {
                //DisplayAlert("Mensaje de Advertencia", ex.Message, "OK");
            }
        }

        private void txtExamenUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                notaExUno = Convert.ToDouble(txtExamenUno.Text);

                //aceptar valores de 1-10
                if (notaExUno < 0)
                {
                    DisplayAlert("MENSAJE DE ALERTA", "No se permite valores menores de 0", "OK");
                    txtExamenUno.Text = "";
                }
                else
                {
                    if (notaExUno > 10)
                    {
                        DisplayAlert("MENSAJE DE ALERTA", "No se permite valores mayores de 10", "OK");
                        txtExamenUno.Text = "";
                    }
                }


            }
            catch (Exception ex)
            {
                //DisplayAlert("Mensaje de Advertencia", ex.Message, "OK");
            }
        }

        private void txtNotaSeguiDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                notaSeguiDos = Convert.ToDouble(txtNotaSeguiDos.Text);

                //aceptar valores de 1-10
                if (notaSeguiDos < 0)
                {
                    DisplayAlert("MENSAJE DE ALERTA", "No se permite valores menores de 0", "OK");
                    txtNotaSeguiDos.Text = "";

                }
                else
                {
                    if (notaSeguiDos > 10)
                    {
                        DisplayAlert("MENSAJE DE ALERTA", "No se permite valores mayores de 10", "OK");
                        txtNotaSeguiDos.Text = "";

                    }
                }


            }
            catch (Exception ex)
            {
                // DisplayAlert("Mensaje de Advertencia", ex.Message, "OK");
            }
        }

        private void txtExamenDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                notaExDos = Convert.ToDouble(txtExamenDos.Text);

                //aceptar valores de 1-10
                if (notaExDos < 0)
                {
                    DisplayAlert("MENSAJE DE ALERTA", "No se permite valores menores de 0", "OK");
                    txtExamenDos.Text = "";
                }
                else
                {
                    if (notaExDos > 10)
                    {
                        DisplayAlert("MENSAJE DE ALERTA", "No se permite valores mayores de 10", "OK");
                        txtExamenDos.Text = "";
                    }
                }


            }
            catch (Exception ex)
            {
                //DisplayAlert("Mensaje de Advertencia", ex.Message, "OK");
            }
        }

        private void btnNotaFinal_Clicked(object sender, EventArgs e)
        {
            try
            {
                //parcial 1
                notaSeguiUno = Convert.ToDouble(txtNotaSeguiUno.Text);
                notaSeguiUno = notaSeguiUno * 0.3;
                notaExUno = Convert.ToDouble(txtExamenUno.Text);
                notaExUno = notaExUno * 0.2;

                parcialUno = notaSeguiUno + notaExUno;
                txtParcialUno.Text = Convert.ToString(parcialUno);

                //parcial 2
                notaSeguiDos = Convert.ToDouble(txtNotaSeguiDos.Text);
                notaSeguiDos = notaSeguiDos * 0.3;
                notaExDos = Convert.ToDouble(txtExamenDos.Text);
                notaExDos = notaExDos * 0.2;

                parcialDos = notaSeguiDos + notaExDos;
                txtParcialDos.Text = Convert.ToString(parcialDos);

                //nota final
                notaFinal = parcialDos + parcialUno;
                txtNotaFinal.Text = Convert.ToString(notaFinal);

                //estado
                if (notaFinal >= 7)
                {
                    txtEstado.Text = "APROBADO";
                    txtEstado.TextColor = Color.DarkGreen;
                }
                else
                {
                    if (notaFinal >= 5 && notaFinal < 7)
                    {
                        txtEstado.Text = "COMPLEMENTARIO";
                        txtEstado.TextColor = Color.Blue;
                    }
                    else
                    {
                        txtEstado.Text = "REPROBADO";
                        txtEstado.TextColor = Color.DarkRed;
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Advertencia", ex.Message, "OK");
            }
        }
    }
}