// See https://aka.ms/new-console-template for more information
using DocumentFormat.OpenXml.Wordprocessing;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using static Product;

namespace ScruffandScalesPetStore
{
    internal record Product(decimal Price, int Quantity, string Description, int LengthInches, string Material, string Name, double WeightPounds, bool IsKittenFood)
    {

    }
}