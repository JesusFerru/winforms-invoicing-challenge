# invoiceproject.ps1 - Script para ejecutar la API y la aplicación de Windows Forms y detener ambos al cerrar la aplicación

# Ruta al proyecto de la API
$apiProjectPath = "./InvoiceServiceMock"

# Ruta al ejecutable de la aplicación Windows Forms
$winFormsExecutablePath = "./InvoiceManager.WinForms/bin/Debug/net8.0-windows/InvoiceManager.WinForms.exe"

# Iniciar la API de Facturación
Write-Host "Iniciando la API de Facturación..."
$apiProcess = Start-Process -NoNewWindow -PassThru "dotnet" "run --project $apiProjectPath --urls=http://localhost:5050/"

# Esperar unos segundos para asegurarse de que la API esté completamente levantada
Write-Host "Esperando que la API se inicie..."
Start-Sleep -Seconds 5

# Verificar si la API está corriendo antes de iniciar la aplicación WinForms
$apiIsRunning = $false

try {
    $response = Invoke-WebRequest -Uri "http://localhost:5050/api/invoices" -UseBasicParsing
    if ($response.StatusCode -eq 200) {
        $apiIsRunning = $true
        Write-Host "La API está corriendo correctamente."
    }
} catch {
    Write-Host "No se pudo conectar a la API. Asegúrese de que la API esté funcionando."
}

# Si la API está corriendo, iniciar la aplicación de Windows Forms
if ($apiIsRunning) {
    Write-Host "Iniciando la aplicación de Windows Forms..."
    $winFormsProcess = Start-Process -NoNewWindow -PassThru $winFormsExecutablePath
} else {
    Write-Host "Error: La API no está disponible. No se puede iniciar la aplicación de Windows Forms."
    Exit
}

# Monitorear el proceso de la aplicación WinForms. Cuando se cierre, detener la API.
Wait-Process -Id $winFormsProcess.Id

# Detener el proceso de la API cuando la aplicación de Windows Forms se cierre
if ($apiProcess -ne $null) {
    Write-Host "La aplicación de Windows Forms ha sido cerrada. Deteniendo la API de Facturación..."
    Stop-Process -Id $apiProcess.Id -Force
    Write-Host "La API de Facturación ha sido detenida."
}
