using System;
using System.Xml;
using System.Text;

namespace Tollervey.AIMLBot.AIML.Elements
{
    /// <summary>
    /// NOT IMPLEMENTED FOR SECURITY REASONS
    /// </summary>
    public class javascript : AIMLElement
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="bot">The bot involved in this request</param>
        /// <param name="user">The user making the request</param>
        /// <param name="query">The query that originated this node</param>
        /// <param name="request">The request inputted into the system</param>
        /// <param name="result">The result to be passed to the user</param>
        /// <param name="templateNode">The node to be processed</param>
        public javascript(AIMLBot.Bot bot,
                        AIMLBot.User user,
                        AIMLBot.Utils.Query query,
                        AIMLBot.Request request,
                        AIMLBot.Result result,
                        XmlNode templateNode)
            : base(bot, user, query, request, result, templateNode)
        {
        }

        protected override string ProcessChange()
        {
            this.bot.writeToLog("The javascript tag is not implemented in this bot");
            return string.Empty;
        }
    }
}
