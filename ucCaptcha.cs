using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;
using General.Librerias.EntidadesNegocio;  

namespace General.Librerias.CodigoUsuario
{
  public class ucCaptcha
  {
    private static char generarCaracterAzar()
    {
      Random oAzar = new Random();
      int n = oAzar.Next(26)+65;
      char c=(char)n;
      return c;
    }
    
    public static beCaptcha CrearCaptcha()
    {
      beCaptcha obeCaptcha = new beCaptcha();
      StringBuilder sb = new StringBuilder();
      foreach(int i=0;i<5;i++)
      {
        sb.Append(generarCaracterAzar());
      }
      Rectangle rec=new Rectangle(0,0,200,8);
      Bitmap bmp =new Bitmap(200,80);
      Grafics grafico = Grafics.FromImage(bmp);
      grafico
      return obeCaptcha;
    }
  }
}
