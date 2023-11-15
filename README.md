# DAE_GestionNotas

La base de datos debe de tener el mismo nombre "dbGestionNotas" en el sql. Si lo tiene como "GestionNotas" no les va a correr, tiene que ser "dbGestionNotas"

En el App.config cambiar las lineas "Makima\SQLEXPRESSR" a la direccion de su sql (cunado abren el sql les aparece el nombre de su compu y la carpeta de su sql)

app.config de la carpeta windowsForm

Linea 16-----------

 <add name="Entities" connectionString="metadata=res://*/ModelAdo.csdl|res://*/ModelAdo.ssdl|res://*/ModelAdo.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=Makima\SQLEXPRESSR;initial catalog=dbGestionNotas;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;
 
Linea 18-------

 connectionString="Data Source=Makima\SQLEXPRESSR;Initial Catalog=dbGestionNotas;Integrated Security=True"

   

Para la carpeta model : seria la linea 13 

source=MAKIMA\SQLEXPRESSR;initial catalog=dbGestionNotas;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
