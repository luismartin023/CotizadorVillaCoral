namespace CotizadorVillaCoral;

public class Reserva
{
    public string Huesped { get; set; } = "";
    public int Noches { get; set; }
    public decimal TarifaPorNoche { get; set; }

    public decimal Subtotal => Noches * TarifaPorNoche;
    public decimal Descuento => Noches >= 7 ? Subtotal * 0.10m : 0m;
    public decimal BaseImponible => Subtotal - Descuento;
    public decimal Itbis => BaseImponible * 0.18m;
    public decimal Servicio => BaseImponible * 0.10m;
    public decimal Total => BaseImponible + Itbis + Servicio;
}
