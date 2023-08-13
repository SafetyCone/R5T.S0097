using System;

using R5T.T0141;


namespace R5T.S0097
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void Get_RepositoryOwnerName()
        {
            /// Inputs.
            var organizationName = Instances.OrganizationNames.DavidCoats;


            /// Run.
            var repositoryOwnerName = Instances.OrganizationNameOperator.Get_RepositoryOwnerName(organizationName);

            Console.WriteLine($"{repositoryOwnerName}: repository owner name for organization '{organizationName}'");
        }
    }
}
