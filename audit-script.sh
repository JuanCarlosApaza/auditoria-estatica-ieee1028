#!/bin/bash
echo "=== Iniciando Auditoría Automatizada de Código ==="

# Restaurar dependencias
echo "Restaurando paquetes..."
dotnet restore DemoAuditApp/DemoAuditApp.csproj

# Ejecutar el build y análisis estático
echo "Ejecutando compilación con analizadores estáticos de código..."
dotnet build DemoAuditApp/DemoAuditApp.csproj --no-restore

# Guardar el resultado del comando anterior
RESULT=$?

if [ $RESULT -eq 0 ]; then
    echo "✅ AUDITORÍA EXITOSA: El código cumple con los estándares exigidos."
    exit 0
else
    echo "❌ AUDITORÍA FALLIDA: Se encontraron defectos de código o violaciones de reglas."
    exit 1
fi