namespace CotizadorVillaCoral;

public class ConsumoMinibar
{
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }

    public decimal Subtotal => Cantidad * PrecioUnitario;
    public decimal Itbis => Subtotal * 0.18m;
    public decimal Total => Subtotal + Itbis;
}
