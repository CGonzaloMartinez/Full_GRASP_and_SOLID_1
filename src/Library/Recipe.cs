//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    /*
        Por otra parte decidimos que la clase recipe debería ser la que calculara
        el costo total de la receta, ya que contiene una lista de todos los steps
        por lo cual sería la clase experta en realizar dicha tarea (Patrón Expert).
    */
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"Precio total: {this.GetProductionCost()}");
        }

        public double GetProductionCost()
        {
            double totalPrice = 0;
            foreach (Step step in steps)
            {
                totalPrice += step.TotalCost();
            }
            return totalPrice;
        }
    }
}