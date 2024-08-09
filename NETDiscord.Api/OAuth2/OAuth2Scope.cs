using System;

namespace NETDiscord.Api.OAuth2
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/topics/oauth2#shared-resources-oauth2-scopes">Discord API Documentation</see>
	/// </summary>
	public enum OAuth2Scope
	{
		ActivitiesRead,
		ActivitiesWrite,
		ApplicationsBuildsRead,
		ApplicationsBuildsUpload,
		ApplicationsCommands,
		ApplicationsCommandsUpdate,
		ApplicationsCommandsPermissionsUpdate,
		ApplicationsEntitlements,
		ApplicationsStoreUpdate,
		Bot,
		Connections,
		DmChannelsRead,
		Email,
		GdmJoin,
		Guilds,
		GuildsJoin,
		GuildsMembersRead,
		Identify,
		MessagesRead,
		RelationshipsRead,
		RoleConnectionsWrite,
		Rpc,
		RpcActivitiesWrite,
		RpcNotificationsRead,
		RpcVoiceRead,
		RpcVoiceWrite,
		Voice,
		WebhookIncoming
	}


	internal static class OAuth2ScopesExtensions
	{
		public const string ActivitiesRead = "activities.read";
		public const string ActivitiesWrite = "activities.write";
		public const string ApplicationsBuildsRead = "applications.builds.read";
		public const string ApplicationsBuildsUpload = "applications.builds.upload";
		public const string ApplicationsCommands = "applications.commands";
		public const string ApplicationsCommandsUpdate = "applications.commands.update";
		public const string ApplicationsCommandsPermissionsUpdate = "applications.commands.permissions.update";
		public const string ApplicationsEntitlements = "applications.entitlements";
		public const string ApplicationsStoreUpdate = "applications.store.update";
		public const string Bot = "bot";
		public const string Connections = "connections";
		public const string DmChannelsRead = "dm_channels.read";
		public const string Email = "email";
		public const string GdmJoin = "gdm.join";
		public const string Guilds = "guilds";
		public const string GuildsJoin = "guilds.join";
		public const string GuildsMembersRead = "guilds.members.read";
		public const string Identify = "identify";
		public const string MessagesRead = "messages.read";
		public const string RelationshipsRead = "relationships.read";
		public const string RoleConnectionsWrite = "role_connections.write";
		public const string Rpc = "rpc";
		public const string RpcActivitiesWrite = "rpc.activities.write";
		public const string RpcNotificationsRead = "rpc.notifications.read";
		public const string RpcVoiceRead = "rpc.voice.read";
		public const string RpcVoiceWrite = "rpc.voice.write";
		public const string Voice = "voice";
		public const string WebhookIncoming = "webhook.incoming";

		public static string AsString(this OAuth2Scope scope)
		{
			return scope switch
			{
				OAuth2Scope.ActivitiesRead => ActivitiesRead,
				OAuth2Scope.ActivitiesWrite => ActivitiesWrite,
				OAuth2Scope.ApplicationsBuildsRead => ApplicationsBuildsRead,
				OAuth2Scope.ApplicationsBuildsUpload => ApplicationsBuildsUpload,
				OAuth2Scope.ApplicationsCommands => ApplicationsCommands,
				OAuth2Scope.ApplicationsCommandsUpdate => ApplicationsCommandsUpdate,
				OAuth2Scope.ApplicationsCommandsPermissionsUpdate => ApplicationsCommandsPermissionsUpdate,
				OAuth2Scope.ApplicationsEntitlements => ApplicationsEntitlements,
				OAuth2Scope.ApplicationsStoreUpdate => ApplicationsStoreUpdate,
				OAuth2Scope.Bot => Bot,
				OAuth2Scope.Connections => Connections,
				OAuth2Scope.DmChannelsRead => DmChannelsRead,
				OAuth2Scope.Email => Email,
				OAuth2Scope.GdmJoin => GdmJoin,
				OAuth2Scope.Guilds => Guilds,
				OAuth2Scope.GuildsJoin => GuildsJoin,
				OAuth2Scope.GuildsMembersRead => GuildsMembersRead,
				OAuth2Scope.Identify => Identify,
				OAuth2Scope.MessagesRead => MessagesRead,
				OAuth2Scope.RelationshipsRead => RelationshipsRead,
				OAuth2Scope.RoleConnectionsWrite => RoleConnectionsWrite,
				OAuth2Scope.Rpc => Rpc,
				OAuth2Scope.RpcActivitiesWrite => RpcActivitiesWrite,
				OAuth2Scope.RpcNotificationsRead => RpcNotificationsRead,
				OAuth2Scope.RpcVoiceRead => RpcVoiceRead,
				OAuth2Scope.RpcVoiceWrite => RpcVoiceWrite,
				OAuth2Scope.Voice => Voice,
				OAuth2Scope.WebhookIncoming => WebhookIncoming,
				_ => throw new ArgumentOutOfRangeException(nameof(scope))
			};
		}
		public static OAuth2Scope ToOAuth2Scope(this string scope)
		{
			return scope switch
			{
				ActivitiesRead => OAuth2Scope.ActivitiesRead,
				ActivitiesWrite => OAuth2Scope.ActivitiesWrite,
				ApplicationsBuildsRead => OAuth2Scope.ApplicationsBuildsRead,
				ApplicationsBuildsUpload => OAuth2Scope.ApplicationsBuildsUpload,
				ApplicationsCommands => OAuth2Scope.ApplicationsCommands,
				ApplicationsCommandsUpdate => OAuth2Scope.ApplicationsCommandsUpdate,
				ApplicationsCommandsPermissionsUpdate => OAuth2Scope.ApplicationsCommandsPermissionsUpdate,
				ApplicationsEntitlements => OAuth2Scope.ApplicationsEntitlements,
				ApplicationsStoreUpdate => OAuth2Scope.ApplicationsStoreUpdate,
				Bot => OAuth2Scope.Bot,
				Connections => OAuth2Scope.Connections,
				DmChannelsRead => OAuth2Scope.DmChannelsRead,
				Email => OAuth2Scope.Email,
				GdmJoin => OAuth2Scope.GdmJoin,
				Guilds => OAuth2Scope.Guilds,
				GuildsJoin => OAuth2Scope.GuildsJoin,
				GuildsMembersRead => OAuth2Scope.GuildsMembersRead,
				Identify => OAuth2Scope.Identify,
				MessagesRead => OAuth2Scope.MessagesRead,
				RelationshipsRead => OAuth2Scope.RelationshipsRead,
				RoleConnectionsWrite => OAuth2Scope.RoleConnectionsWrite,
				Rpc => OAuth2Scope.Rpc,
				RpcActivitiesWrite => OAuth2Scope.RpcActivitiesWrite,
				RpcNotificationsRead => OAuth2Scope.RpcNotificationsRead,
				RpcVoiceRead => OAuth2Scope.RpcVoiceRead,
				RpcVoiceWrite => OAuth2Scope.RpcVoiceWrite,
				Voice => OAuth2Scope.Voice,
				WebhookIncoming => OAuth2Scope.WebhookIncoming,
				_ => throw new ArgumentOutOfRangeException(nameof(scope))
			};
		}
	}
}
