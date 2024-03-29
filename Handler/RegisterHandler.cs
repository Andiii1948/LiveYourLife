﻿using AltV.Net.Async;
using AltV.Net.Elements.Entities;
using AltV.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.Handler
{
    class RegisterHandler : IScript
    {
        [AsyncClientEvent("Server:Register:RegisterNewPlayer")]
        public async Task RegisterNewPlayer(IPlayer player, string username, string email, string pass, string passrepeat)
        {
            if (player == null || !player.Exists) return;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(passrepeat))
            {
                player.EmitLocked("Client:Login:showError", "Eines der Felder wurde nicht ordnungsgemäß ausgefüllt.");
                return;
            }

            if (User.ExistPlayerName(username))
            {
                player.EmitLocked("Client:Login:showError", "Der eingegebene Benutzername ist bereits vergeben.");
                return;
            }

            if (User.ExistPlayerEmail(email))
            {
                player.EmitLocked("Client:Login:showError", "Die eingegebene E-Mail ist bereits vergeben.");
                return;
            }

            if (pass != passrepeat)
            {
                player.EmitLocked("Client:Login:showError", "Die eingegebenen Passwörter stimmen nicht überein.");
                return;
            }

            if (User.ExistPlayerSocialClub(player))
            {
                player.EmitLocked("Client:Login:showError", "Es existiert bereits ein Konto mit deiner Socialclub ID.");
                return;
            }

            User.CreatePlayerAccount(player, username, email, pass);
            player.EmitLocked("Client:Login:showArea", "login");
        }
    }
}
