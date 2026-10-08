namespace CotizadorVillaCoral;

public static class SistemaViejo
{
    public static decimal CalcularDeposito(decimal total)
    {
        decimal porcentaje = 0.30m;
        decimal deposito = total * porcentaje;
        return deposito;
    }

    public static decimal APesos(decimal dolares, decimal tasa)
    {
        decimal pesos = dolares * tasa;
        return pesos;
    }

    public static decimal TarifaFinDeSemana(decimal tarifa, bool esFinDeSemana)
    {
        if (esFinDeSemana)
        {
            tarifa = tarifa * 1.15m;
        }
        return tarifa;
    }

    public static decimal TotalExcursion(int personas, decimal precio)
    {
        decimal subtotal = personas * precio;
        decimal descuento = 0m;
        if (personas >= 4)
        {
            descuento = subtotal * 0.10m;
        }
        return subtotal - descuento;
    }

    public static decimal TotalMinibar(int cantidad, decimal precio)
    {
        decimal subtotal = cantidad * precio;
        decimal itbis = subtotal * 0.18m;
        decimal total = subtotal + itbis;
        return total;
    }
}
