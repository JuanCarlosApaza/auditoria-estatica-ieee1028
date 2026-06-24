# Checklist de Auditoría Estática (IEEE 1028)

## 1. Estándares de Código C#
- [ ] ¿Las variables y métodos siguen la nomenclatura PascalCase/camelCase de .NET?
- [ ] ¿Se evitan tipos de datos mágicos o alias no estandarizados?

## 2. Seguridad Básica
- [ ] ¿Se validan todas las entradas del usuario antes de ser procesadas?
- [ ] ¿Se evita la exposición de datos sensibles en consola o logs?

## 3. Mantenibilidad y Manejo de Errores
- [ ] ¿Existen bloques try-catch para capturar excepciones inesperadas?
- [ ] ¿El código carece de números mágicos o lógica redundante dura?

## 4. Documentación
- [ ] ¿El código cuenta con comentarios XML (`///`) en funciones principales?

## 5. Cumplimiento DevOps
- [ ] ¿El archivo .csproj tiene activado `<TreatWarningsAsErrors>true`?