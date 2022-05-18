using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

var employeeR = new GenericRepositoryWithRemove<Employee>();

employeeR.Add(new Employee {Id = 1,FirstName="shakil" });
employeeR.Add(new Employee { Id = 2, FirstName = "yousuf" });
employeeR.Add(new Employee { Id = 3, FirstName = "robin" });
employeeR.Add(new Employee { Id = 4, FirstName = "mashuq" });
employeeR.Remove(new Employee { Id = 1, FirstName = "shakil" });
employeeR.Save();


var OrganizationR = new GenericRepository<Organization, Guid>();

OrganizationR.Add(new Organization { Id = 1, Name = "Moon" });
OrganizationR.Add(new Organization { Id = 2, Name = "Sun" });
OrganizationR.Add(new Organization { Id = 3, Name = "East" });
OrganizationR.Add(new Organization { Id = 4, Name = "West" });

OrganizationR.Save();