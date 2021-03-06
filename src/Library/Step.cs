//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    /*
        Decidimos que Step debería ser la clase encargada de calcular el costo total del step en si, ya que es el experto (Patrón Expert),
        tiene toda la información necesaria para realizar esa tarea, porque conoce los productos y sus cantidades,
        y el equipamiento y su tiempo de uso.
        Esta clase también cumple con el SRP, ya que el único motivo de cambio que tiene es que el step se cree de otra forma, lo cual
        cambiaría el calculo del costo.
    */
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        public double TotalCost()
        {
            return ((this.Input.UnitCost * this.Quantity) + (this.Equipment.HourlyCost * (this.Time/60)));
        }
    }
}