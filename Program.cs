using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_descuentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double montoconsumo;
            double descuento;
            double impuesto;
            double totaldescuento;
            double totalpagar;

            Console.WriteLine("Ingrese el monto del consumo: ");
            montoconsumo = Convert.ToDouble(Console.ReadLine());

            if (montoconsumo <= 100)
            {
                descuento = montoconsumo * 0.10;
            }
            else
            {
                descuento = montoconsumo * 0.20;
            }

            totaldescuento = montoconsumo - descuento;
            impuesto = totaldescuento * 0.18;
            totalpagar = totaldescuento + impuesto;

            Console.WriteLine($"Monto del descuento: S/ {descuento:F2}");
            Console.WriteLine($"Impuesto: S/ {impuesto:F2}");
            Console.WriteLine($"Subtotal: S/ {totaldescuento:F2}");
            Console.WriteLine($"Importe a pagar: S/ {totalpagar:F2}");
        }
    }
}