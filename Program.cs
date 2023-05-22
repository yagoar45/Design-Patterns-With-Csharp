using DesignPatterns._2___ChainOfResposibility.TruthModel;
using DesignPatterns._3___TemplateMethod.TruthModel;
using DesignPatterns._5___State.TruthModel;
using DesignPatterns._6___Builder.ErrorModel;
using DesignPatterns._6___Builder.TruthModel;
using DesignPatterns._6___Builder_e_Observer.TruthModel;


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


Console.WriteLine("================ TEMPLATE METHOD ============================");
Console.WriteLine("\n");
var budget3 = new  BudgetTruth(800);



var ICPP = new ICPPTruth();


Console.WriteLine($"No caso do ICPP, O desconto foi de: {ICPP.Discount(budget3)}");

Console.WriteLine("\n");


// the correct use State pattern

// =====================================================================================================
// ===================================== STATE =========================================================
// =====================================================================================================

Console.WriteLine("================ STATE ============================");
Console.WriteLine("\n");


var budget4 = new BudgetTruthChangeOk(600);

Console.WriteLine($"O valor do budget é: {budget4.Value}");

budget4.ApplyExtraTax();


budget4.IsAprroved();

budget4.ApplyExtraTax();

Console.WriteLine($"O valor do budget após aprovação é: {budget4.Value}");

Console.WriteLine("\n");




// the correct use Builder pattern

// ================================================================================================================
// ===================================== BUILDER E OBSERVER =======================================================
// ================================================================================================================

Console.WriteLine("================ BUILDER ============================");
Console.WriteLine("\n");


var invoiceBuilder = new BuildInvoice();

invoiceBuilder
    .ForCompanies("AXIOS LTDA")
    .WithCnpj("5135138019312")
    .WithItem(new ItemInvoice("Caixa de Som", 560))
    .WithItem(new ItemInvoice("Mesa de Sinuca", 300))
    .WithNotes("OBS: cuidado para não se divertir demais");



invoiceBuilder.AddAction(new SenderDb());
invoiceBuilder.AddAction(new SenderEmail());
invoiceBuilder.AddAction(new SenderSMS());


var invoice = invoiceBuilder.BuildeAInvoice();

Console.WriteLine($"VALOR BRUTO ARRECADADO: {invoice.GrossValue}");
Console.WriteLine($"IMPOSTO DECLARADO NA NOTA FISCAL: {invoice.Taxs}");
Console.WriteLine($"DATA DE EMISSÃO: {invoice.IssueDate}");

Console.WriteLine("\n");