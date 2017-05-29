using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO.Controller
{
    public class TipoDeConta
    {
        public enum enumTipoConta
        {
           
            [Description("IPTU")]
            IPTU = 0,            
            [Description("Água")]
            Agua = 1,
            [Description("Lúz")]
            Luz = 2,
            [Description("Telefone")]
            Telefone = 3,
            [Description("Condomínio")]
            Condominio = 4,
            [Description("Aluguel")]
            Aluguel = 5,
            [Description("Rateio")]
            Rateio = 6
                        }
        public static string EnumDescription(Enum e)
        {
            Type t = e.GetType();
            DescriptionAttribute[] att = { };

            if (Enum.IsDefined(t, e))
            {
                FieldInfo fieldInfo = t.GetField(e.ToString());
                att = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            }
            return (att.Length > 0 ? att[0].Description ?? "Nulo" : e.ToString());
        }


        public static IList EnumList(Type t)
        {
            ArrayList ret = new ArrayList();
            if (t != null)
            {
                Array enumValores = Enum.GetValues(t);
                foreach (Enum valor in enumValores)
                {
                    ret.Add(new KeyValuePair<int, string>(Convert.ToInt32(valor), EnumDescription(valor)));
                }
            }

            return (ret);
        }
    }
}
