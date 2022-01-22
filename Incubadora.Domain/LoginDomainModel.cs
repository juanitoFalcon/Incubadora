﻿namespace Incubadora.Domain
{
    public class LoginDomainModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        //asociamos el rol del usuario al objeto loginDomainModel
        public AspNetRolesDomainModel aspNetRoles { get; set; }
    }
}
