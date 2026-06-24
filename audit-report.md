# Reporte de Auditoría de Sistemas - IEEE 1028

[cite_start]**Proyecto Auditado:** DemoAuditApp [cite: 77]
**Resultado del Pipeline:** ❌ FALLIDO

## 1. Hallazgos Detectados
- [cite_start]**Falta de Validación de Entradas:** El método `int.Parse(Console.ReadLine())` asume que el usuario siempre ingresará dígitos[cite: 83, 90].
- [cite_start]**Ausencia de Manejo de Excepciones:** Si se ingresa una letra, la aplicación crashea inmediatamente de forma descontrolada[cite: 91].
- [cite_start]**Cero Documentación:** No existen comentarios técnicos explicativos ni estructuras XML[cite: 92].

## 2. Riesgos Asociados
- **Denegación de Servicio Local (Crash):** El hilo de ejecución se rompe fácilmente, afectando la disponibilidad del sistema.
- **Inyección de código / Errores de lógica:** Controlar el flujo mediante excepciones no manejadas debilita la seguridad de la app.

## 3. Recomendaciones de Mitigación
1. Reemplazar `int.Parse` por `int.TryParse` para verificar la entrada de forma segura.
2. Implementar bloques `try-catch` para control preventivo de errores imprevistos.