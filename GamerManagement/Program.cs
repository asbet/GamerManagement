using GamerManagement;
UserManagement userManagement= new UserManagement();
userManagement.Add(new Gamer() { identityNumber = "11", name = "Betul", surName = "As", birthDate = new DateTime(1999, 11, 10) });
userManagement.Update(new Gamer() { identityNumber = "11", name = "Betul", surName = "Asd", birthDate = new DateTime(1999, 11, 10) });
userManagement.Delete(new Gamer() { identityNumber = "11", name = "Betul", surName = "As", birthDate = new DateTime(1999, 11, 10) });