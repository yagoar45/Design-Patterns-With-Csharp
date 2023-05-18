
// the correct use strategy pattern
var iss = new ISSTruth();
var icms = new ICMSTruth();

BudgetTruth budget = new BudgetTruth(500);

Console.WriteLine(iss.Calc(budget));

Console.WriteLine(icms.Calc(budget));

