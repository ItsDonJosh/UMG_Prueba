Este proyecto está basado en el lenguaje .Net utilizando el IDE Visual Studio Community 2015, la herramienta de versionamiento Github, la herramienta Jenkins, Buddy Works y por supuesto una máquina Virtual implementada desde Microsoft Azure utilizando una cuenta de Microsoft Dreamspark para estudiantes.

Ya teniendo instalado el IDE de Visual Studio Community 2015 (con el plugin de Github) y también un proyecto en el cual se va a trabajar, para luego subirlo a la nube con Github para eso se procede a lo siguiente:

Crear una cuenta en Github (nos servirá para alojar nuestro proyecto en la nube)

1.	Ingresar a: https://github.com/

2.	Escribe un usuario, una correo electrónico y una contraseña y da clic en Crear cuenta (Create an account)

3.	Selecciona tu tipo de Plan, puedes tener tantos repositorios como quieras pero si lo quieres gratis tendrán que ser públicos, privados te cuesta aproximadamente $7.00 al mes.

4.	Y listo ya puedes conectar Github con VisualStudio Community 2015

Ahora pasamos a la creación de la Maquina Virtual, Instalación y Configuración de Jenkins y Buddy.Works

Necesitamos crear una cuenta de Microsoft Dreamspark para estudiantes

1.	Ingresar a la página oficial de Dreamspark: www.Dreamspark.com y elegir la opción de estudiantes.

2.	En las opciones de la parte inferior (Crear la cuenta), clickea en la opción de “Crear la cuenta”.

3.	Luego, te pedirá que inicies sesión con un correo activo de Outlook, ingresa tu correo y contraseña.

4.	En la siguiente página, te pedirá información básica para tu cuenta de Dreamspark, ingresa todo correctamente y presiona “Continuar para comprobar”.

5.	Para comprobar que realmente eres un estudiante tienes cinco opciones, la que recomiendan usar es la opción “Puedo cargar una foto de un documento de matriculación escolar”.

6.	Llena los datos que allí se te piden y da clic en Enviar.

7.	Espera de 3 a 5 días hábiles para recibir un correo que te indica que ya puedes usar los productos de Dreamspark.

Cuando ya tengas creada tu cuenta de Dreamspark ya puedes registrarte en Microsoft Azure.

1.	Entra a Microsoft Dreamspark e inicia sesión y dirígete a “Descargar Software” y luego a “Ir a Catálogo de Software para Estudiantes”.

2.	En el apartado “Servidores y Aplicaciones” y entra a “Microsoft Azure para DreamSpark”.

3.	Da clic, en Registrar Ahora e inicia sesión con tu cuenta de Dreamspark y sigue los pasos siguientes.
3.1.	Si te da algún tipo de error al momento de ingresar a Microsoft Azure desde Dreamspark dirígete a www.portal.azure.com puede ser una posible solución a tu problema.

4.	Ahora ya podrías crear una máquina Virtual o cualquier otro servicio.


Crear la máquina Virtual en Microsoft Azure, sigue estos pasos:

1.	Dentro del portal de Azure, dirígete a Máquinas Virtuales, en el menú de la parte superior de ese apartado da clic en Add (Añadir).

2.	Te dirigirá al MarketPlace de Máquinas Virtuales allí selecciona la ideal para tu proyecto, en este recetario se usará Windows Server 2012 Datacenter, selecciónala y selecciona un Modelo de Despliegue (Select a deployment model), se recomienda Administrador de Recursos (Resource Manager).


3.	Si te aparece que actualices a Premium solo necesitas darle clic a Actualizar e introducir la información de tu tarjeta de crédito o débito y se te debitará un costo de $1.00 y con ese dólar Microsoft Azure gracias a Dreamspark te regala $200.00 o 30 días de Premium para que los utilices en tu proyecto.

4.	En el apartado Básico (Basics), escribe un nombre para identificar a tu máquina Virtual, escribe un Nombre de Usuario y una contraseña (te servirán para iniciar sesión al momento de conectarte a tu máquina Virtual), crea un nuevo Grupo de Recursos y selecciona la locación de tu Máquina Virtual y da clic en Aceptar.

5.	En el apartado Almacenamiento (Choose a Size) utiliza el almacenamiento que tenga por promedio menor cantidad de dólares para que te alcancen los $200.00 que te regalaron y da clic en Select (Seleccionar).

6.	En el Apartado de Settings (Configuración) deja la configuración predeterminada y luego en Aceptar (OK).

7.	Luego se te muestra un Resumen para que revises todas las configuraciones, si esta todo correcto presiona Aceptar (OK) y ahora espera en lo que se crea la Máquina Virtual.

8.	Cuando ya este creada la Máquina Virtual, ingresa en Máquinas Virtuales, selecciona la que has creado y en la parte superior haz clic en Connect (Conectar), se descargará un archivo .rdp, guárdalo donde se tengas fácil acceso a el.

9.	A abrir ese archivo .rdp te aparecerá una advertencia activa el check de “Don´t ask me again for connections to this computer” (No preguntarme al conectarme otra vez a esta computadora).

10.	En la siguiente ventana, da clic en “Use another account” (Usar otra cuenta), allí ingresa tu usuario y contraseña que ingresaste al crear tu Máquina Virtual. 

11.	Luego vuelve a activar el check de “Don´t ask me again…” y presiona en Yes (Si). Ese error es común.

12.	Ahora ya iniciaste sesión y puedes usar tu Máquina Virtual.

La siguiente serie de pasos es para Administrar Jenkins en la Máquina Virtual.

1.	Ya dentro de tu Máquina Virtual Instala Git: https://git-scm.com/

2.	Instala MSBuild Tools: https://www.microsoft.com/en-us/download/details.aspx?id=48159

3.	Y por último y lo más importante, Instala Jenkins: https://jenkins.io/

4.	Entra a Jenkins desde tu navegador, localhost:8080 (esta dirección la puedes cambiar dentro de las configuraciones de Jenkins pero en este recetario no abarcaremos ese tema).

5.	Entra en “Manage Jenkins” y luego a “Manage Plugins”. En la pestaña “Available” busca todos los Plugins que tengan que ver con Git y Github y selecciónalos, además busca el Plugin de MSBuild y presiona en “Download now and install after restart” (Descarga ahora e instala después del reinicio”. Al momento de estar instalando los plugins selecciona el checkbox de “Restart Jenkins…”.

6.	Con los plugins instalados, Ingresa nuevamente a Manage Jenkins y luego a “Global Tool Configuration”.

7.	En el apartado de Git, en Name escribe un nombre cualquiera: “Git, localgit, etc” y en “Path to Git executable” ingresa la ruta en donde se encuentra instalado Git en tu Máquina Virtual, la común es: C:\Program Files\Git\bin\git.exe, también en esa misma página pero más abajo configura MSBuild, en Name ingresa un nombre cualquiera: “MSBuild, Default, etc” y en “Path to MSBuild ingresa la ruta de dirección, la común es: C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe o solo MSBuild (ver 7.1)
7.1.	Si quieres tener predeterminado MSBuild en tu Maquina Virual, ingresa a Computer -> System Properties -> Advanced system settings -> Environment Variables. En System Variables busca la Variable “Path”, seleccionala y da clic en “Edit” y en “Variable value” borra todo lo que contenga y pega la ruta donde se encuentra MSBuild.exe, quedaría una ruta más o menos así: C:\Program Files (x86)\MSBuild\14.0\Bin

8.	Damos clic en Guardar (Save).

Ahora seria de configurar un nuevo Proyecto (Job) para ello seguimos los siguientes pasos:

1.	Escribir un nombre al Proyecto en Project Name.

2.	En el apartado GitHub Project escribe la url de tu repositorio de GitHub.

3.	En el apartado Git copia también ese mismo link de tu repositorio solo que al final se tiene que agregar la extensión “.git”.

4.	Busca el CheckBox que dice “Inject envioronment variables to the build process” y escribe la siguiente línea en “Properties Content”: PATH=$PATH:C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe, o donde tengas instalado MSBuild en tu Máquina Virtual

5.	Por último, en el apartado Build selecciona la opción “Build a Visual Studio Project or solution using MSBuild” y en MSBuild Version selecciona la que hayas creado en el apartado “Administrar Jenkins”. Y en “MSBuild Build File” escribe lo siguiente sin las comillas: “${WORKSPACE}\FormProy\FormProy.sln

6.	Presiona en Save.

7.	Entra a tu proyecto y en el Menú de la Izquierda presiona Build Now para que Jenkins pueda ver los cambios que has hecho en tu proyecto.

Existe otra plataforma que nos muestra los cambios que se han hecho, se le llama Buddy Works. Los pasos a seguir se encuentran en el vídeo de YouTube: https://www.youtube.com/watch?v=5M3jr4K7m3Y depues del minuto 58:45 en adelante. 

