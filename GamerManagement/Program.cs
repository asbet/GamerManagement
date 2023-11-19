using GamerManagement;
using GamerManagement.Game_Component;

UserManagement userManagement= new UserManagement();

Gamer gamer= new Gamer() { identityNumber = "11", name = "Betul", surName = "As", birthDate = new DateTime(1999, 11, 10) };
Chars chars = new Chars();
Snippers snippers = new Snippers(); 
userManagement.Add(gamer);
userManagement.Update(gamer);
userManagement.Delete(gamer);

chars.purchase(gamer);
snippers.purchase(gamer);
snippers.updatedPurchase(gamer);    
