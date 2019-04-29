﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CardsForMemoryLibrary.IServices;
using CardsForMemoryLibrary.Models;

namespace CardsForMemoryLibrary.Services {
    public class FeedbackService : IFeedbackService {
        /// <summary>
        ///     卡片服务
        /// </summary>
        private ICardService _cardService;

        /// <summary>
        ///     构造函数
        /// </summary>
        /// <param name="cardService"></param>
        public FeedbackService(ICardService cardService) {
            _cardService = cardService;
        }

        public async Task Utility(Card card, Level level) {
            var updateCard = new Card() {
                Id = card.Id,
                Answer = card.Answer,
                Options = card.Options,
                PackageId = card.PackageId,
                Proficiency = card.Proficiency,
                Question = card.Question,
                UpdateTime = DateTime.Now
            };
            switch (level) {
                case Level.Easy:
                    updateCard.Proficiency += 200;
                    break;
                case Level.Normal:
                    updateCard.Proficiency += 100;
                    break;
                case Level.Difficult:
                    break;
                default:
                    //随便抛了个不知名异常
                    throw new KeyNotFoundException();
            }

            if (updateCard.Proficiency > 10000)
                updateCard.Proficiency = 10000;
            await _cardService.EditAsyncCard(updateCard);
        }

        public bool Submit(Card card, string answer) {
            throw new NotImplementedException();
        }
    }

    
}