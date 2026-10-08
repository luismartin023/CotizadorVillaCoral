namespace CotizadorVillaCoral;

public partial class Form1 : Form
{
    private const int UltimoDigitoMatricula = 0;

    private int Pasajeros => (int)nudPersonas.Value;
    private int PersonasExcursion => Pasajeros + 2;
    private decimal PrecioExcursion => 45 + 5 * UltimoDigitoMatricula;
    private int CantidadMinibar => UltimoDigitoMatricula + 2;

    public Form1()
    {
        InitializeComponent();
    }

    private Reserva CrearReserva()
    {
        return new Reserva
        {
            Huesped = txtHuesped.Text,
            Noches = (int)nudNoches.Value,
            TarifaPorNoche = nudTarifa.Value
        };
    }

    private Reserva CrearReservaConFinDeSemana()
    {
        decimal tarifa = nudTarifa.Value;
        if (chkFinSemana.Checked)
        {
            tarifa = tarifa * 1.15m;
        }

        return new Reserva
        {
            Huesped = txtHuesped.Text,
            Noches = (int)nudNoches.Value,
            TarifaPorNoche = tarifa
        };
    }

    private TrasladoAeropuerto CrearTraslado()
    {
        return new TrasladoAeropuerto
        {
            Pasajeros = Pasajeros,
            Nocturno = true
        };
    }

    private Excursion CrearExcursion()
    {
        return new Excursion
        {
            Personas = PersonasExcursion,
            PrecioPorPersona = PrecioExcursion
        };
    }

    private ConsumoMinibar CrearMinibar()
    {
        return new ConsumoMinibar
        {
            Cantidad = CantidadMinibar,
            PrecioUnitario = 3.50m
        };
    }

    private void btnNivel1_Click(object sender, EventArgs e)
    {
        int a = 10;
        int b = 3;
        int r = a / b;
        lstResultados.Items.Add($"1.1  r = {r}");

        decimal r2 = 10 / 4m;
        lstResultados.Items.Add($"1.2  r = {r2}");

        int x = 5;
        x = x + 2;
        x = x * 3;
        lstResultados.Items.Add($"1.3  x = {x}");

        decimal p = 200m;
        decimal r4 = p * 0.18m;
        lstResultados.Items.Add($"1.4  r = {r4}");

        int n = 7;
        decimal d = 0m;
        if (n > 7)
        {
            d = 50m;
        }
        lstResultados.Items.Add($"1.5  d = {d}");

        bool larga = n >= 7;
        lstResultados.Items.Add($"1.6  larga = {larga}");

        string s = "Villa" + "Coral";
        lstResultados.Items.Add($"1.7  s = {s}");

        int n8 = 4;
        decimal t8 = 100m;
        decimal total = n8 * t8 * 1.28m;
        lstResultados.Items.Add($"1.8  total = {total}");

        decimal t = 120m;
        t = t + t * 0.25m;
        lstResultados.Items.Add($"1.9  t = {t}");

        int noches = (int)8.9m;
        lstResultados.Items.Add($"1.10 noches = {noches}");
    }

    private void btnPesos_Click(object sender, EventArgs e)
    {
        var reserva = CrearReserva();
        decimal tasa = nudTasa.Value;
        decimal pesos = reserva.Total * tasa;
        lstResultados.Items.Add($"Total en pesos: RD$ {pesos:N2}");
    }

    private void btnPorPersona_Click(object sender, EventArgs e)
    {
        var reserva = CrearReserva();
        decimal porPersona = reserva.Total / nudPersonas.Value;
        lstResultados.Items.Add($"Cada persona paga: US$ {porPersona:N2}");
    }

    private void btnDeposito_Click(object sender, EventArgs e)
    {
        var reserva = CrearReserva();
        decimal deposito = reserva.Total * 0.30m;
        decimal saldo = reserva.Total - deposito;
        lstResultados.Items.Add($"Depósito (30%): US$ {deposito:N2}");
        lstResultados.Items.Add($"Saldo pendiente: US$ {saldo:N2}");
    }

    private void btnFinSemana_Click(object sender, EventArgs e)
    {
        var reserva = CrearReservaConFinDeSemana();
        lstResultados.Items.Add($"Total con fin de semana: US$ {reserva.Total:N2}");
    }

    private void btnDesglose_Click(object sender, EventArgs e)
    {
        var reserva = CrearReserva();
        lstResultados.Items.Add($"Subtotal:       US$ {reserva.Subtotal:N2}");
        lstResultados.Items.Add($"Descuento:      US$ {reserva.Descuento:N2}");
        lstResultados.Items.Add($"Base imponible: US$ {reserva.BaseImponible:N2}");
        lstResultados.Items.Add($"ITBIS (18%):    US$ {reserva.Itbis:N2}");
        lstResultados.Items.Add($"Servicio (10%): US$ {reserva.Servicio:N2}");
        lstResultados.Items.Add($"Total:          US$ {reserva.Total:N2}");
    }

    private void btnTraslado_Click(object sender, EventArgs e)
    {
        var traslado = CrearTraslado();
        lstResultados.Items.Add($"Traslado aeropuerto (nocturno, {traslado.Pasajeros} pasajeros): US$ {traslado.Total:N2}");
    }

    private void btnExcursion_Click(object sender, EventArgs e)
    {
        var excursion = CrearExcursion();
        lstResultados.Items.Add($"Excursión Saona ({excursion.Personas} personas x {excursion.PrecioPorPersona:N2}): US$ {excursion.Total:N2}");
    }

    private void btnMinibar_Click(object sender, EventArgs e)
    {
        var minibar = CrearMinibar();
        lstResultados.Items.Add($"Minibar ({minibar.Cantidad} x {minibar.PrecioUnitario:N2} + ITBIS): US$ {minibar.Total:N2}");
    }

    private void btnCuentaTotal_Click(object sender, EventArgs e)
    {
        var reserva = CrearReserva();
        var traslado = CrearTraslado();
        var excursion = CrearExcursion();
        var minibar = CrearMinibar();

        decimal cuenta = reserva.Total + traslado.Total + excursion.Total + minibar.Total;
        lstResultados.Items.Add($"Cuenta total de la estadía: US$ {cuenta:N2}");
    }

    private void btnViejo_Click(object sender, EventArgs e)
    {
        lstResultados.Items.Add($"Depósito de 1000: {SistemaViejo.CalcularDeposito(1000m):N2} (debe dar 300.00)");
        lstResultados.Items.Add($"100 USD a tasa 60: {SistemaViejo.APesos(100m, 60m):N2} (debe dar 6,000.00)");
        lstResultados.Items.Add($"Tarifa 200 fin de semana: {SistemaViejo.TarifaFinDeSemana(200m, true):N2} (debe dar 230.00)");
        lstResultados.Items.Add($"Excursión 4 x 50: {SistemaViejo.TotalExcursion(4, 50m):N2} (debe dar 180.00)");
        lstResultados.Items.Add($"Minibar 3 x 4: {SistemaViejo.TotalMinibar(3, 4m):N2} (debe dar 14.16)");
    }

    private void btnFactura_Click(object sender, EventArgs e)
    {
        var reserva = CrearReservaConFinDeSemana();
        var traslado = CrearTraslado();
        var excursion = CrearExcursion();
        var minibar = CrearMinibar();

        decimal totalGeneral = reserva.Total + traslado.Total + excursion.Total + minibar.Total;
        decimal totalPesos = SistemaViejo.APesos(totalGeneral, nudTasa.Value);
        decimal deposito = SistemaViejo.CalcularDeposito(totalGeneral);

        lstResultados.Items.Add($"===== FACTURA · {reserva.Huesped} =====");
        lstResultados.Items.Add($"Estadía ({reserva.Noches} noches):  US$ {reserva.Total:N2}");
        lstResultados.Items.Add($"Traslado aeropuerto:              US$ {traslado.Total:N2}");
        lstResultados.Items.Add($"Excursión isla Saona:             US$ {excursion.Total:N2}");
        lstResultados.Items.Add($"Consumo minibar:                  US$ {minibar.Total:N2}");
        lstResultados.Items.Add($"TOTAL GENERAL:                    US$ {totalGeneral:N2}");
        lstResultados.Items.Add($"TOTAL EN PESOS:                   RD$ {totalPesos:N2}");
        lstResultados.Items.Add($"Depósito para confirmar (30%):    US$ {deposito:N2}");
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        lstResultados.Items.Clear();
    }
}
