namespace CotizadorVillaCoral;

public class Excursion
{
    public int Personas { get; set; }
    public decimal PrecioPorPersona { get; set; }

    public decimal Subtotal => Personas * PrecioPorPersona;
    public decimal Descuento => Personas >= 4 ? Subtotal * 0.10m : 0m;
    public decimal Total => Subtotal - Descuento;
}
