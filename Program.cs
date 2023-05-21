using DesignPatterns._2___ChainOfResposibility.TruthModel;
using DesignPatterns._3___TemplateMethod.TruthModel;


// the correct use Strategy pattern

// =====================================================================================================
// ===================================== STRATEGY ======================================================
// =====================================================================================================

Console.WriteLine("================ DESIGN PATTERNS =====================");
Console.WriteLine("\n");

Console.WriteLine("================ STRATEGY ============================");
Console.WriteLine("\n");
var iss = new ISSTruth();
var icms = new ICMSTruth();

BudgetTruth budget = new BudgetTruth(500);

Console.WriteLine($"O ISS pago foi: {iss.Calc(budget)}");

Console.WriteLine($"O ICMS pago foi: {icms.Calc(budget)}");

Console.WriteLine("\n");

// the correct use Chain of Responsibility pattern

// =====================================================================================================
// ===================================== CHAIN OF RESPONSIBILITY =======================================
// =====================================================================================================


Console.WriteLine("================ CHAIN OF RESPONSIBILITY ============================");
Console.WriteLine("\n");

var calc = new CalcDiscountTruth();

var budget2 = new BudgetTruth(500);

budget2.addItem(new ItemTruth("IPHONE 15", 12000));
budget2.addItem(new ItemTruth("SOFT DRINK", 10));
budget2.addItem(new ItemTruth("GFORCE", 125));
budget2.addItem(new ItemTruth("PIZZA", 100));
budget2.addItem(new ItemTruth("ROLEX", 125000));
budget2.addItem(new ItemTruth("MUSTANG", 600000));


double discount = calc.Discount(budget2);


Console.WriteLine($"Nesse caso, o desconto obtido foi: {discount}");

Console.WriteLine("\n");


// the correct use Template Method pattern

// =====================================================================================================
// ===================================== TEMPLATE METHOD ===============================================
// =====================================================================================================

var budget3 = new  BudgetTruth(500);



var ICPP = new ICPPTruth();


Console.WriteLine($"No caso do ICPP, O desconto foi de: {ICPP.Discount(budget)}");

Console.WriteLine("\n");