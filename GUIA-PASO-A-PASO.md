# Cotizador Villa Coral · Guía paso a paso desde cero

Guía completa del ejercicio autoguiado ISW-123 (Hotel Villa Coral).
Está escrita en el mismo orden del mandato: primero los datos, luego el proyecto, GitHub y los 5 niveles.

---

## 0. Antes de tocar Visual Studio: tus datos

Todo el ejercicio usa números que salen de **tu matrícula**. Con una matrícula como `2024-0157`:

- **D** = último dígito → `7`
- **E** = penúltimo dígito → `5`

| Dato | Fórmula | Con el ejemplo |
|---|---|---|
| Noches (N) | D + 3 | 10 |
| Tarifa por noche (T) | 100 + 10 × E | US$ 150 |
| Personas (P) | 2 + (D % 3) | 3 |
| Tasa del dólar | 59 + (D % 5) | RD$ 61 |
| Personas excursión | P + 2 | 5 |
| Precio excursión | 45 + 5 × D | US$ 80 |
| Cantidad minibar | D + 2 | 9 |

Anota los tuyos: los usas en los niveles 2 y 3, y el comprobador de la guía los valida.

En el proyecto, el último dígito vive en una constante de `Form1.cs`:

```csharp
private const int UltimoDigitoMatricula = 0;   // ← cambia el 0 por tu D
```

---

## 1. Crear el proyecto

1. Visual Studio → **Crear un proyecto** → **Aplicación de Windows Forms** (C#).
2. Nombre: `Cotizador_TuMatricula` (en este proyecto: `CotizadorVillaCoral`).
3. En la ventana, cambia la propiedad **Text** por tu nombre y matrícula:
   `Cotizador Villa Coral · Tu Nombre · 2024-0157`.

### Controles obligatorios

Arrastra desde el Cuadro de herramientas y cambia el **(Name)** ANTES de hacer doble clic:

| Control | (Name) | Propiedades |
|---|---|---|
| TextBox | `txtHuesped` | Text: tu nombre |
| NumericUpDown | `nudNoches` | Minimum 1 · Maximum 60 |
| NumericUpDown | `nudTarifa` | DecimalPlaces 2 · Maximum 10000 |
| NumericUpDown | `nudTasa` | DecimalPlaces 2 · Maximum 1000 |
| NumericUpDown | `nudPersonas` | Minimum 1 · Maximum 20 |
| CheckBox | `chkFinSemana` | Text: «Fin de semana (+15%)» |
| ListBox | `lstResultados` | Grande, ocupa la mitad inferior |
| Buttons | ver niveles | Uno por cálculo |

Pon una Label al lado de cada caja.

### Reglas de oro de Windows Forms

1. Cambia el **(Name)** antes del doble clic.
2. Si se crea un método vacío por error, **no lo borres**: déjalo vacío.
3. **Text** es lo que ve el usuario; **Name** es como lo llamas en el código.

---

## 2. La clase Reserva

Clic derecho en el proyecto → **Agregar → Clase…** → `Reserva.cs`:

```csharp
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
```

### Cómo explicarla línea por línea

- `public string Huesped { get; set; } = "";` → propiedad de entrada; empieza como texto vacío para que nunca sea `null`.
- `public int Noches { get; set; }` → número entero de noches.
- `public decimal TarifaPorNoche { get; set; }` → dinero, por eso `decimal` y no `int`.
- `Subtotal => Noches * TarifaPorNoche` → propiedad **calculada**: no se guarda, se calcula cada vez que la pides. El `=>` se lee «se calcula como».
- `Descuento => Noches >= 7 ? Subtotal * 0.10m : 0m` → **operador ternario**: `condición ? valor_si_true : valor_si_false`. Si son 7 noches o más, 10% de descuento.
- `BaseImponible => Subtotal - Descuento` → sobre esto se cobran los impuestos.
- `Itbis => BaseImponible * 0.18m` → 18%.
- `Servicio => BaseImponible * 0.10m` → 10%.
- `Total => BaseImponible + Itbis + Servicio` → lo que paga el huésped.

> La `m` al final de `0.10m` significa «este número es `decimal`». Sin la `m`, C# lo trata como `double` y el dinero pierde precisión.

---

## 3. GitHub (obligatorio, antes del nivel 1)

1. Crea tu cuenta en github.com (usuario serio, ej. `anagomez-dev`).
2. Visual Studio → **Archivo → Configuración de la cuenta → Agregar → GitHub** → Authorize.
3. **Git → Crear repositorio Git…** → elige GitHub:
   - Nombre: `ISW123-Cotizador-TuMatricula`
   - **Desmarcar** «Repositorio privado»
   - Plantilla .gitignore: **Visual Studio** (así no suben `bin/` ni `obj/`)
4. **Crear e insertar**. Verifica en github.com que esté el `.sln`, el `.gitignore` y la carpeta del proyecto.
5. Al terminar **cada nivel**: `Ctrl+Shift+S` → **Ver → Cambios de Git** → mensaje → **Confirmar todo e insertar**.

Mensajes que pide el mandato:

| Momento | Mensaje de commit |
|---|---|
| Creación | (el inicial de Visual Studio) |
| Nivel 1 | `Nivel 1: ejercicios de valores comprobados en Visual Studio` |
| Nivel 2 | `Nivel 2: botones de pesos, por persona, deposito, fin de semana y desglose` |
| Nivel 3 | `Nivel 3: clases TrasladoAeropuerto, Excursion y ConsumoMinibar` |
| Nivel 4 | `Nivel 4: corregidos los 5 bugs de SistemaViejo` |
| Nivel 5 | `Nivel 5: factura de la estadia` |

Al final deben verse **al menos 6 commits**.

---

## 4. Nivel 1 · ¿Cuánto vale?

Un botón `btnNivel1` ejecuta los 10 ejercicios y muestra cada resultado. Lo importante es **por qué** da eso:

```csharp
int a = 10;
int b = 3;
int r = a / b;                      // 1.1 → 3 (int/int corta decimales)

decimal r2 = 10 / 4m;               // 1.2 → 2.5 (la m lo hace decimal)

int x = 5;
x = x + 2;                          // x vale 7
x = x * 3;                          // 1.3 → 21

decimal p = 200m;
decimal r4 = p * 0.18m;             // 1.4 → 36 (el 18%)

int n = 7;
decimal d = 0m;
if (n > 7) { d = 50m; }             // 1.5 → 0 (7 > 7 es false)

bool larga = n >= 7;                // 1.6 → true (>= sí incluye el 7)

string s = "Villa" + "Coral";       // 1.7 → "VillaCoral" (+ pega textos)

int n8 = 4;
decimal t8 = 100m;
decimal total = n8 * t8 * 1.28m;    // 1.8 → 512 (ITBIS+servicio a la vez)

decimal t = 120m;
t = t + t * 0.25m;                  // 1.9 → 150 (recargo del 25%)

int noches = (int)8.9m;             // 1.10 → 8 ((int) CORTA, no redondea)
```

**Commit:** `Nivel 1: ejercicios de valores comprobados en Visual Studio`

---

## 5. Nivel 2 · Un botón por cálculo

Todos empiezan igual: crear la reserva con los datos de la ventana.

```csharp
private Reserva CrearReserva()
{
    return new Reserva
    {
        Huesped = txtHuesped.Text,
        Noches = (int)nudNoches.Value,      // .Value es decimal → (int) lo convierte
        TarifaPorNoche = nudTarifa.Value
    };
}
```

### 2.1 · Total en pesos (`btnPesos`)

```csharp
var reserva = CrearReserva();
decimal tasa = nudTasa.Value;
decimal pesos = reserva.Total * tasa;
lstResultados.Items.Add($"Total en pesos: RD$ {pesos:N2}");
```

Dólares → pesos se **multiplica** por la tasa. `$"..."` interpola texto; `:N2` = miles + 2 decimales.

### 2.2 · Por persona (`btnPorPersona`)

```csharp
var reserva = CrearReserva();
decimal porPersona = reserva.Total / nudPersonas.Value;
lstResultados.Items.Add($"Cada persona paga: US$ {porPersona:N2}");
```

Se divide entre `decimal` (no `int`) para no perder los centavos.

### 2.3 · Depósito y saldo (`btnDeposito`)

```csharp
var reserva = CrearReserva();
decimal deposito = reserva.Total * 0.30m;   // 30% para confirmar
decimal saldo = reserva.Total - deposito;   // el resto al llegar
lstResultados.Items.Add($"Depósito (30%): US$ {deposito:N2}");
lstResultados.Items.Add($"Saldo pendiente: US$ {saldo:N2}");
```

### 2.4 · Recargo de fin de semana (`btnFinSemana`)

```csharp
decimal tarifa = nudTarifa.Value;
if (chkFinSemana.Checked)
{
    tarifa = tarifa * 1.15m;                // SUBIR 15% = × 1.15
}
var reserva = new Reserva { ..., TarifaPorNoche = tarifa };
lstResultados.Items.Add($"Total con fin de semana: US$ {reserva.Total:N2}");
```

Ojo: `* 0.15m` da solo el 15%; `* 1.15m` da el 100% + 15%.

### 2.5 · Desglose (`btnDesglose`)

Seis `Items.Add`, uno por propiedad de `Reserva`: `Subtotal`, `Descuento`, `BaseImponible`, `Itbis`, `Servicio`, `Total`. No hay que calcular nada: la clase ya lo hace.

**Commit:** `Nivel 2: botones de pesos, por persona, deposito, fin de semana y desglose`

---

## 6. Nivel 3 · Tus propias clases

Mismo patrón que `Reserva`: entradas con `{ get; set; }`, cálculos con `=>`.

### 3.1 · `TrasladoAeropuerto.cs`

```csharp
public class TrasladoAeropuerto
{
    public int Pasajeros { get; set; }
    public bool Nocturno { get; set; }

    public decimal Subtotal => Pasajeros * 25m;
    public decimal Recargo => Nocturno ? Subtotal * 0.20m : 0m;
    public decimal Total => Subtotal + Recargo;
}
```

El ternario usa el `bool` directo como condición: `Nocturno ? ... : 0m`.

### 3.2 · `Excursion.cs`

```csharp
public class Excursion
{
    public int Personas { get; set; }
    public decimal PrecioPorPersona { get; set; }

    public decimal Subtotal => Personas * PrecioPorPersona;
    public decimal Descuento => Personas >= 4 ? Subtotal * 0.10m : 0m;
    public decimal Total => Subtotal - Descuento;
}
```

«4 o más» = `>= 4`.

### 3.3 · `ConsumoMinibar.cs`

```csharp
public class ConsumoMinibar
{
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }

    public decimal Subtotal => Cantidad * PrecioUnitario;
    public decimal Itbis => Subtotal * 0.18m;
    public decimal Total => Subtotal + Itbis;
}
```

### 3.4 · `btnCuentaTotal`

Un botón puede crear varios objetos y sumar sus totales:

```csharp
var reserva = CrearReserva();
var traslado = new TrasladoAeropuerto { Pasajeros = Pasajeros, Nocturno = true };
var excursion = new Excursion { Personas = PersonasExcursion, PrecioPorPersona = PrecioExcursion };
var minibar = new ConsumoMinibar { Cantidad = CantidadMinibar, PrecioUnitario = 3.50m };

decimal cuenta = reserva.Total + traslado.Total + excursion.Total + minibar.Total;
lstResultados.Items.Add($"Cuenta total de la estadía: US$ {cuenta:N2}");
```

**Commit:** `Nivel 3: clases TrasladoAeropuerto, Excursion y ConsumoMinibar`

---

## 7. Nivel 4 · Caza de bugs (`SistemaViejo.cs`)

Cinco métodos `static` (se llaman sin `new`: `SistemaViejo.APesos(...)`), cada uno con **un** error. Los corregidos:

| Método | Bug | Corrección |
|---|---|---|
| `CalcularDeposito` | `0.03m` (3%) | `0.30m` (30%) |
| `APesos` | `dolares / tasa` | `dolares * tasa` |
| `TarifaFinDeSemana` | `tarifa * 0.15m` (queda en 15%) | `tarifa * 1.15m` |
| `TotalExcursion` | `personas > 4` (con 4 no entra) | `personas >= 4` |
| `TotalMinibar` | `return subtotal` | `return total` |

Versión corregida:

```csharp
public static decimal CalcularDeposito(decimal total)
{
    decimal porcentaje = 0.30m;
    decimal deposito = total * porcentaje;
    return deposito;
}
```

Para encontrarlos tú: `F9` en la primera línea del botón → `F5` → clic → `F11` para entrar al método → `F10` línea a línea mirando los valores.

**Commit:** `Nivel 4: corregidos los 5 bugs de SistemaViejo`

---

## 8. Nivel 5 · `btnFactura` (la entrega)

Junta todo en una factura:

```csharp
private void btnFactura_Click(object sender, EventArgs e)
{
    // 1. Reserva aplicando el recargo si el checkbox está marcado
    var reserva = CrearReservaConFinDeSemana();

    // 2. Los otros servicios con tus datos
    var traslado = CrearTraslado();
    var excursion = CrearExcursion();
    var minibar = CrearMinibar();

    // 3. Totales
    decimal totalGeneral = reserva.Total + traslado.Total
                         + excursion.Total + minibar.Total;
    decimal totalPesos = SistemaViejo.APesos(totalGeneral, nudTasa.Value);
    decimal deposito = SistemaViejo.CalcularDeposito(totalGeneral);

    // 4. Mostrar la factura
    lstResultados.Items.Add($"===== FACTURA · {reserva.Huesped} =====");
    lstResultados.Items.Add($"Estadía ({reserva.Noches} noches):  US$ {reserva.Total:N2}");
    lstResultados.Items.Add($"Traslado aeropuerto:              US$ {traslado.Total:N2}");
    lstResultados.Items.Add($"Excursión isla Saona:             US$ {excursion.Total:N2}");
    lstResultados.Items.Add($"Consumo minibar:                  US$ {minibar.Total:N2}");
    lstResultados.Items.Add($"TOTAL GENERAL:                    US$ {totalGeneral:N2}");
    lstResultados.Items.Add($"TOTAL EN PESOS:                   RD$ {totalPesos:N2}");
    lstResultados.Items.Add($"Depósito para confirmar (30%):    US$ {deposito:N2}");
}
```

**Commit:** `Nivel 5: factura de la estadia`

### Entrega en Moodle

1. Verifica en GitHub: archivos completos, **≥6 commits**, sin `bin/` ni `obj/`.
2. Pega el **enlace del repositorio** en la tarea.
3. Adjunta dos capturas:
   - La ventana tras hacer clic en Factura (nombre y matrícula visibles en el título).
   - El depurador detenido dentro de `btnFactura_Click` con el mouse sobre una variable.

---

## 9. Preguntas que te puede hacer el docente (y su respuesta)

- **¿Por qué `decimal` y no `int`?** Porque el dinero tiene centavos; `int` corta los decimales.
- **¿Qué hace `=>`?** Define una propiedad calculada: se evalúa cada vez que se lee, no guarda un valor fijo.
- **¿Qué es `? :`?** Un `if` en una línea: `condicion ? siTrue : siFalse`.
- **¿Por qué `(int)nudNoches.Value`?** `NumericUpDown.Value` siempre es `decimal`; `(int)` lo convierte cortando decimales.
- **¿Por qué `* 1.15m` y no `* 0.15m`?** `0.15` es SOLO el 15%; `1.15` es el total más el 15%.
- **¿Qué es `static`?** El método pertenece a la clase, no a un objeto: se llama `SistemaViejo.APesos(...)` sin `new`.
- **¿Qué hace `$"Total: {x:N2}"`?** Mete la variable en el texto y la formatea con miles y 2 decimales.
- **¿Dónde está el descuento de la reserva?** En la propiedad `Descuento`: solo si `Noches >= 7`.
- **¿De dónde salen tus números?** Del último y penúltimo dígito de tu matrícula (ver sección 0).

---

## 10. Atajos del depurador

| Tecla | Hace |
|---|---|
| `F9` | Pone/quita punto de interrupción (bolita roja) |
| `F5` | Ejecuta con depurador |
| `F10` | Avanza una línea (sin entrar a métodos) |
| `F11` | Avanza una línea entrando a métodos |
| `Shift+F5` | Detiene todo |

La flecha amarilla marca la línea que **va** a ejecutarse, no la que ya se ejecutó.
