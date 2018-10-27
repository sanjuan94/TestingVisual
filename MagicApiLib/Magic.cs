using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;
using MtgApiManager.Lib.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicApiLib
{
    public class Magic
    {
        CardService service;
        public Magic()
        {
            service = new CardService();
        }

        /// <summary>
        /// Function SearchCardsId
        /// return the card with specific id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Exceptional<Card>> SearchCardId(int id)
        {
            Exceptional<Card> output;
            try { 
                output = await service.FindAsync(id);
                return output;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Function GetCardsPage
        /// return the x=[_pageSize] cards.  
        /// </summary>
        /// <param name="_page"></param>
        /// <param name="_pageSize"></param>
        /// <returns></returns>
        public async Task<Exceptional<List<Card>>> GetCardsPage(int _page, int _pageSize=10)
        {
            Exceptional<List<Card>> output;
            output = await service.Where(x => x.Page, _page)
                            .Where(x => x.PageSize, 250)
                            .AllAsync();
            return output;
        }
    }
}
