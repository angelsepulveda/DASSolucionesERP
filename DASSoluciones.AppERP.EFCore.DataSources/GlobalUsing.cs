#region Core
global using DASSoluciones.AppERP.EFCore.DataSources.Core.Options;
global using DASSoluciones.AppERP.EFCore.DataSources.Core.Contexts;
#endregion

#region Modules
global using DASSoluciones.AppERP.EFCore.DataSources.Modules.Settings;
#endregion

#region Libreries
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Options;
global using Microsoft.Extensions.DependencyInjection;
#endregion

#region DocumentTypes
global using DASSoluciones.AppERP.Backend.Repositories.Modules.Settings.DocumentTypes.Models;
global using DASSoluciones.AppERP.DBAdmin.Modules.Settings.DocumentTypes.Configurations;
global using DASSoluciones.AppERP.Backend.BusinessObject.Modules.Settings.DocumentTypes.Entities;
global using DASSoluciones.AppERP.Backend.Repositories.Modules.Settings.DocumentTypes.Interfaces;
global using DASSoluciones.AppERP.EFCore.DataSources.Modules.Settings.DocumentTypes.DataSources;
global using DASSoluciones.AppERP.EFCore.DataSources.Modules.Settings.DocumentTypes;
#endregion