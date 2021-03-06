﻿using System;

using Discord.WebSocket;

using Modix.Common.Messaging;

namespace Discord
{
    /// <summary>
    /// Describes an application-wide notification that occurs when <see cref="IBaseSocketClient.JoinedGuild"/> is raised.
    /// </summary>
    public class JoinedGuildNotification : INotification
    {
        /// <summary>
        /// Constructs a new <see cref="JoinedGuildNotification"/> from the given values.
        /// </summary>
        /// <param name="guild">The value to use for <see cref="Guild"/>.</param>
        /// <exception cref="ArgumentNullException">Throws for <paramref name="guild"/>.</exception>
        public JoinedGuildNotification(ISocketGuild guild)
        {
            Guild = guild ?? throw new ArgumentNullException(nameof(guild));
        }

        /// <summary>
        /// The guild that the bot has joined.
        /// </summary>
        public ISocketGuild Guild { get; }
    }
}
