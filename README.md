# DAE_GestionNotas

En el App.config cambiar las lineas "Makima\SQLEXPRESSR" a la direccion de su sql (cunado abren el sql les aparece el nombre de su compu y la carpeta de su sql)

la base de datos debe de tener el mismo nombre "dbGestionNotas" en el sql. Si lo tiene como "GestionNotas" no les va a correr, tiene que ser "dbGestionNotas"

app.config de la carpeta windowsForm
Linea 16
 <add name="Entities" connectionString="metadata=res://*/ModelAdo.csdl|res://*/ModelAdo.ssdl|res://*/ModelAdo.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=Makima\SQLEXPRESSR;initial catalog=dbGestionNotas;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;
Linea 18
 connectionString="Data Source=Makima\SQLEXPRESSR;Initial Catalog=dbGestionNotas;Integrated Security=True"

   
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <configSections>
    <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
   <!--  <section name="entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false" />
  </configSections>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8" />
  </startup>
  <entityFramework>
    <providers>
      <provider invariantName="System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer" />
    </providers>
  </entityFramework>
	<connectionStrings>
---------------- linea 16 --------------- <add name="Entities" connectionString="metadata=res://*/ModelAdo.csdl|res://*/ModelAdo.ssdl|res://*/ModelAdo.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=Makima\SQLEXPRESSR;initial catalog=dbGestionNotas;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;"
   providerName="System.Data.EntityClient" />
  <add name="WindowsFormsApp1.Properties.Settings.dbGestionNotasConnectionString"
----------------- linea 18 -------------connectionString="Data Source=Makima\SQLEXPRESSR;Initial Catalog=dbGestionNotas;Integrated Security=True"
   providerName="System.Data.SqlClient" />
 </connectionStrings>
</configuration>


Para la carpeta model : seria la linea 13 

<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <configSections>
    <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
  <!--   <section name="entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false" />
  </configSections>
  <entityFramework>
    <providers>
      <provider invariantName="System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer" />
    </providers>
  </entityFramework>
  <connectionStrings>
  -------------linea 13---------------  <add name="Entities" connectionString="metadata=res://*/ModelAdo.csdl|res://*/ModelAdo.ssdl|res://*/ModelAdo.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=MAKIMA\SQLEXPRESSR;initial catalog=dbGestionNotas;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
</configuration>
