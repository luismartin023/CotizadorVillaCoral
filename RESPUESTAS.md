# Respuestas · ISW-123 Hotel Villa Coral

Respuestas verificadas contra el comprobador de la guía (los hashes coinciden).
Los ejercicios 2.x y 3.x dependen de tu matrícula: aquí van las fórmulas y un ejemplo completo.

> Ojo: la guía dice que el docente puede pedirte explicar cualquier línea. Esto es para comprobar tu trabajo, no para copiar a ciegas.

---

## 0.1 · Enlace del repositorio

Respuesta: tu URL real, formato `https://github.com/tu-usuario/ISW123-Cotizador-TuMatricula`
Ejemplo: `https://github.com/luismartin023/CotizadorVillaCoral`

---

## Nivel 1 · ¿Cuánto vale? (respuestas fijas — iguales para todos)

| Ej. | Código | Respuesta | Por qué |
|---|---|---|---|
| 1.1 | `int r = 10 / 3` | **3** | int ÷ int corta decimales |
| 1.2 | `decimal r = 10 / 4m` | **2.5** | la `m` hace división decimal |
| 1.3 | `x=5; x=x+2; x=x*3` | **21** | 5 → 7 → 21 |
| 1.4 | `200m * 0.18m` | **36** | el 18% de 200 |
| 1.5 | `if (n > 7) d=50` con n=7 | **0** | 7 > 7 es false, no entra |
| 1.6 | `bool larga = n >= 7` | **true** | >= sí incluye al 7 |
| 1.7 | `"Villa" + "Coral"` | **VillaCoral** | `+` pega sin espacio |
| 1.8 | `4 * 100m * 1.28m` | **512** | total con ITBIS+servicio |
| 1.9 | `120 + 120*0.25` | **150** | recargo del 25% |
| 1.10 | `(int)8.9m` | **8** | `(int)` corta, no redondea |

---

## Tus datos (salen de tu matrícula)

Sea **D** = último dígito y **E** = penúltimo dígito.

| Dato | Fórmula |
|---|---|
| Noches (N) | D + 3 |
| Tarifa (T) | 100 + 10 × E |
| Personas (P) | 2 + (D % 3) |
| Tasa | 59 + (D % 5) |
| Personas excursión | P + 2 |
| Precio excursión | 45 + 5 × D |
| Cantidad minibar | D + 2 |

### Tabla rápida por D

| D | N | P | Tasa | Precio excursión | Cant. minibar |
|---|---|---|------|------------------|---------------|
| 0 | 3 | 2 | 59 | 45 | 2 |
| 1 | 4 | 3 | 60 | 50 | 3 |
| 2 | 5 | 4 | 61 | 55 | 4 |
| 3 | 6 | 2 | 62 | 60 | 5 |
| 4 | 7 | 3 | 63 | 65 | 6 |
| 5 | 8 | 4 | 59 | 70 | 7 |
| 6 | 9 | 2 | 60 | 75 | 8 |
| 7 | 10 | 3 | 61 | 80 | 9 |
| 8 | 11 | 4 | 62 | 85 | 10 |
| 9 | 12 | 2 | 63 | 90 | 11 |

### Tabla rápida por E (tarifa T = 100 + 10E)

| E | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |
|---|---|---|---|---|---|---|---|---|---|---|
| T | 100 | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 |

### La reserva base (con tus N y T)

```
subtotal   = N × T
descuento  = N >= 7 ? subtotal × 0.10 : 0
base       = subtotal − descuento
itbis      = base × 0.18
servicio   = base × 0.10
total      = base + itbis + servicio   (= base × 1.28)
```

---

## Nivel 2 · Un botón por cálculo (depende de tus datos)

| Ej. | Qué pide | Fórmula |
|---|---|---|
| 2.1 | Total en RD$ | `total × tasa` |
| 2.2 | Pago por persona | `total ÷ P` |
| 2.3 | **Saldo pendiente** | `total × 0.70` (depósito = `total × 0.30`) |
| 2.4 | Total con fin de semana | reserva con `T × 1.15` → `base' × 1.28` |
| 2.5 | **ITBIS** | `base × 0.18` |

## Nivel 3 · Clases (depende de tus datos)

| Ej. | Qué pide | Fórmula |
|---|---|---|
| 3.1 | Traslado nocturno | `P × 25 × 1.20` |
| 3.2 | Excursión | `(P+2) × (45+5D)`, si P+2 ≥ 4 → `× 0.90` |
| 3.3 | Minibar | `(D+2) × 3.50 × 1.18` |
| 3.4 | Cuenta total | `total reserva + traslado + excursión + minibar` |

---

## Ejemplo resuelto completo (matrícula que termina en **…57**)

D=7, E=5 → N=10, T=150, P=3, tasa=61, P2=5, precioExc=80, cantMini=9.

Reserva: subtotal 1500 → descuento 150 → base 1350 → **total US$ 1,620.00**

| Ej. | Cálculo | Respuesta |
|---|---|---|
| 2.1 | 1620 × 61 | **RD$ 98,820.00** |
| 2.2 | 1620 ÷ 3 | **US$ 540.00** |
| 2.3 | 1620 × 0.70 | **US$ 1,134.00** |
| 2.4 | (150×1.15=172.5) → 10×172.5=1725, desc 172.5, base 1552.5, ×1.28 | **US$ 1,987.20** |
| 2.5 | 1350 × 0.18 | **US$ 243.00** |
| 3.1 | 3 × 25 × 1.20 | **US$ 90.00** |
| 3.2 | 5 × 80 × 0.90 | **US$ 360.00** |
| 3.3 | 9 × 3.50 × 1.18 | **US$ 37.17** |
| 3.4 | 1620 + 90 + 360 + 37.17 | **US$ 2,107.17** |

*(Con otra matrícula, sustituye tus N, T, P, tasa y D en las fórmulas.)*

---

## Nivel 4 · Caza de bugs — número de línea del error

La línea 1 es la que empieza con `public static`.

| Ej. | Método | Línea | Bug → corrección |
|---|---|---|---|
| 4.1 | `CalcularDeposito` | **3** | `0.03m` → `0.30m` (el depósito es 30%) |
| 4.2 | `APesos` | **3** | `dolares / tasa` → `dolares * tasa` |
| 4.3 | `TarifaFinDeSemana` | **5** | `tarifa * 0.15m` → `tarifa * 1.15m` |
| 4.4 | `TotalExcursion` | **5** | `personas > 4` → `personas >= 4` |
| 4.5 | `TotalMinibar` | **6** | `return subtotal` → `return total` |

---

## Nivel 5 · Factura (sin comprobador, lo revisa el docente)

Debe mostrar: reserva (con recargo si el checkbox está marcado) + traslado + excursión + minibar, total general en US$ y RD$ con tu tasa, y el depósito del 30%.

Con el ejemplo (…57, sin fin de semana): total general **US$ 2,107.17** → RD$ **128,537.37** (×61) → depósito **US$ 632.15**.

### Checklist de entrega

- [ ] Repo público con `.sln`, clases y `SistemaViejo` corregido
- [ ] Mínimo 6 commits con mensajes por nivel
- [ ] Sin carpetas `bin`/`obj` en GitHub
- [ ] Enlace pegado en Moodle
- [ ] Captura 1: factura ejecutada con tu nombre/matrícula en el título
- [ ] Captura 2: depurador dentro de `btnFactura_Click` mostrando una variable
