# Evidencia de Uso de IA Generativa (IEEE 1028)

Este documento registra la interacción con la IA para el codiseño del mecanismo de auditoría estática automatizada.

## Prompt 1: Entendimiento del Contexto y Estructura
**Usuario:**
> [Aquí pegas el texto inicial que me pasaste, que incluye el problema de DevOps y la rúbrica]

**Respuesta de la IA:**
- Explicación del rol como Auditor de Sistemas.
- Hoja de ruta con los 5 componentes clave (`checklist.md`, `audit-script.sh`, `.github/workflows/audit.yml`, `audit-report.md`, `prompts-ia.md`).
- Estructura de carpetas recomendada para cumplir con el nivel avanzado de la rúbrica.

## Prompt 2: Configuración Técnica del Proyecto C#
**Usuario:**
> [Pega aquí el contenido de tu archivo .csproj original] esto debo editar??

**Respuesta de la IA:**
- Instrucciones detalladas para modificar el archivo `.csproj`.
- Inclusión de las propiedades estrictas de análisis:
  - `<AnalysisLevel>latest</AnalysisLevel>`
  - `<TreatWarningsAsErrors>true</TreatWarningsAsErrors>`
- Explicación del impacto preventivo de romper la compilación si existen advertencias de calidad.

## Prompt 3: Automatización del Pipeline en Windows y Linux
**Usuario:**
> touch checklist.md "touch" no se reconoce como un comando interno o externo...

**Respuesta de la IA:**
- Corrección de sintaxis de comandos para entornos Windows (CMD vs Git Bash).
- Provisión de alternativas equivalentes (`type nul > checklist.md`) para mantener la fluidez del desarrollo del proyecto.