# Cotizador Villa Coral

Proyecto de ISW-123: cotizador de estadía del Hotel Villa Coral en C# y Windows Forms.

## Estructura

- `CotizadorVillaCoral.sln` — solución (un solo proyecto).
- `CotizadorVillaCoral/` — aplicación Windows Forms.
  - `Form1.cs` — ventana principal con los botones de cada nivel.
  - `Reserva.cs` — reserva de la estadía (subtotal, descuento, ITBIS, servicio, total).
  - `TrasladoAeropuerto.cs` — traslado con recargo nocturno.
  - `Excursion.cs` — excursión con descuento para grupos de 4 o más.
  - `ConsumoMinibar.cs` — consumo de minibar con ITBIS.
  - `SistemaViejo.cs` — métodos estáticos ya corregidos (nivel 4).

## Cómo ejecutar

Abrir `CotizadorVillaCoral.sln` en Visual Studio y presionar F5, o por terminal:

```
dotnet build CotizadorVillaCoral.sln
dotnet run --project CotizadorVillaCoral
```

## Personalizar con tus datos

En `Form1.cs` cambia la constante `UltimoDigitoMatricula` por el último dígito de tu matrícula y pon tus noches, tarifa, personas y tasa en la ventana. Cambia también el `Text` del formulario en `Form1.Designer.cs` por tu nombre y matrícula.
