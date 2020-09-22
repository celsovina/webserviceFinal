using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webservice
{
    public partial class inicial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        List<string> Persona = new List<string>();
        List<string> Deducciones = new List<string>();
        List<string> Devengados = new List<string>();
        string SueldoTotal;
        int ValorSueldo;

        protected void Button1_Click(object sender, EventArgs e)
        {
            ValorSueldo = Convert.ToInt32(LabelSueldo.Text);
            ServiceReference1.WebService1SoapClient Servicio1 = new ServiceReference1.WebService1SoapClient();
            SueldoTotal = Servicio1.CalculoSueldo(ValorSueldo, Convert.ToInt32(DropDownListDom.SelectedValue), Convert.ToInt32(fallas.Text), Convert.ToInt32(horasext.Text));
            Persona = Servicio1.Persona(txtIdent.Text, Nombre.Text, Apellido.Text, DropDownListCargo.SelectedValue);
            Deducciones = Servicio1.Deducciones(fallas.Text);
            Devengados = Servicio1.Devengados(DropDownListDom.SelectedValue);
            string Salud = Deducciones[1]; 
        }

        protected void DropDownListCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Cargo = DropDownListCargo.SelectedValue;
            switch (Cargo)
            {
                case "Asesor":
                    LabelSueldo.Text = "877900";
                    break;
                case "Mercaderista":
                    LabelSueldo.Text = "1100900";
                    break;
                case "Supervisor":
                    LabelSueldo.Text = "1609900";
                    break;
                case "Coordinador":
                    LabelSueldo.Text = "2100900";
                    break;

            }
        }
    }
}