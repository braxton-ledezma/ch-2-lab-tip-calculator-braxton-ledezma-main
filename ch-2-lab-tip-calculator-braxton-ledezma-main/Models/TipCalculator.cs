using System.ComponentModel.DataAnnotations;

namespace Ch2Lab.Models;

public class TipCalculator {
    
    [Required]
    [Range(0, double.MaxValue)]
    public double MealCost { get; set; } = 0;

    public List<Tip> Tips {get;set;} = new List<Tip>();

    public void CalculateTips() {
        Tips.Clear();

        Tips.Add(new Tip() {Label = "15% tip:", Value = this.MealCost * 0.15, Total = MealCost * 1.15});
        Tips.Add(new Tip() {Label = "20% tip:", Value = this.MealCost * 0.20,  Total = MealCost * 1.2});
        Tips.Add(new Tip() {Label = "25% tip:", Value = this.MealCost * 0.25,  Total = MealCost * 1.25});
    }
    public double CalculateTip15() {
        return MealCost * 0.15;
    }

    public double CalculateTip20() {
        return MealCost * 0.20;
    }

    public double CalculateTip25() {
        return MealCost * 0.25;
    }
}

public class Tip
{
    public string? Label {get; set; }
    public double Value {get; set; }
    public double Total {get; set; }
}