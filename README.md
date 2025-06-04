**1.Create SmartInventory.Data Class Library**
cd SmartInventorySystem
dotnet new classlib -n SmartInventory.Data
dotnet sln add SmartInventory.Data

**2. Add References**
dotnet add SmartInventory.API reference SmartInventory.Data

**3. Install EF Core Packages**
cd SmartInventory.API
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design

**4. Create Product & Category Models**
📄 SmartInventory.Data/Models/Product.cs
📄 SmartInventory.Data/Models/Category.cs

**5. Setup DbContext**
📄 SmartInventory.Data/AppDbContext.cs

**6. Register DbContext in API**
📄 SmartInventory.API/Program.cs (Add these before builder.Build())

**7.📄 SmartInventory.API/appsettings.json (Add connection string)**
⚠️ Update "localhost" to your SQL Server instance if needed (e.g., localhost\\SQLEXPRESS).

**8. Add EF Migration & Update DB**
✅ From SmartInventory.API folder:
dotnet ef migrations add InitialCreate --project ../SmartInventory.Data --startup-project . 
dotnet ef database update --project ../SmartInventory.Data --startup-project .

✅ This will create the database SmartInventoryDb with two tables.

**9. ** Git Commands for Day 2****
cd ..
git checkout -b feature/day-2-efcore-setup
git add .
git commit -m "Day 2: Added EF Core setup, Product and Category models, DbContext, migration"
** Set Git to Use Windows Certificate Store (Best Practice)**
git config --global http.sslBackend schannel
_schannel tells Git to use Windows' built-in certificate store (instead of its own)._
git push -u origin feature/day-2-efcore-setup
