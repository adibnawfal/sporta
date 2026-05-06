using Sporta.Data.Static;
using Sporta.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sporta.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                // Products
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name = "Nike Pegasus Turbo SE",
                            ProductCategory = ProductCategory.Running,
                            Price = 669,
                            Description = "Let this esteemed stallion help you log the hard miles. Complete with lighter, responsive foam and a feathery upper, this motley-coloured mare helps you increase tempo without sacrificing comfort as you push towards a personal best. Sharp, bright hues complement dark-room colour neutrals, speaking to an inclusive world where digital and physical coexist in harmony.",
                            Color = "Black/Green Abyss/Hyper Pink/Fuchsia Dream",
                            Style = "FB7183-001",
                            Picture1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/40c4c1c9-d330-4517-8a28-1a760fa99a48/pegasus-turbo-next-nature-se-road-running-shoes-tHT957.png",
                            Picture2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/8b495f8c-e9fc-4f7e-9f12-08f1541b723f/pegasus-turbo-next-nature-se-road-running-shoes-tHT957.png",
                            Picture3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/406e062d-6f91-40ed-8fc9-a5624ccce907/pegasus-turbo-next-nature-se-road-running-shoes-tHT957.png",
                            Picture4 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/90d94939-2ed4-4b9a-b859-ff41ee6a42c2/pegasus-turbo-next-nature-se-road-running-shoes-tHT957.png",
                            Picture5 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/062e2bf1-86ca-438e-90ae-6226fc497e1c/pegasus-turbo-next-nature-se-road-running-shoes-tHT957.png",
                            Picture6 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/9b538cf4-b979-4e60-9c99-5c8290f0cc4c/pegasus-turbo-next-nature-se-road-running-shoes-tHT957.png"
                        },
                        new Product()
                        {
                            Name = "Nike Waffle Debut SE",
                            ProductCategory = ProductCategory.Lifestyle,
                            Price = 339,
                            Description = "Retro running style gets modernised in this special-edition Nike Waffle Debut. Era-echoing suede and nylon are paired with a modern wedge-shaped midsole for a look that feels fresh and classic. Of course, we kept our tried, true and tested Waffle outsole on the bottom to add durable traction and a touch of character to your every step.",
                            Color = "Neutral Olive/Dark Stucco/Sea Glass/Dark Smoke Grey",
                            Style = "FJ4196-200",
                            Picture1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/6b624fcc-7810-4644-9a51-40a65ca1a5d5/waffle-debut-se-shoes-zPhTV5.png",
                            Picture2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/6853e1b6-ad0d-4970-929d-48846152dafa/waffle-debut-se-shoes-zPhTV5.png",
                            Picture3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/a6744b0b-9b31-4018-bda4-49524f9413a1/waffle-debut-se-shoes-zPhTV5.png",
                            Picture4 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/f1971be9-30d7-4693-9d46-e6a58466c8f8/waffle-debut-se-shoes-zPhTV5.png",
                            Picture5 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/afad1a2a-781a-42b1-8215-3c81e445c34a/waffle-debut-se-shoes-zPhTV5.png",
                            Picture6 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/a19f6f5d-6379-4a58-917f-035b3461b08e/waffle-debut-se-shoes-zPhTV5.png"
                        },
                        new Product()
                        {
                            Name = "KD Trey 5 X EP",
                            ProductCategory = ProductCategory.Basketball,
                            Price = 369,
                            Description = "With its lightweight upper and plush support system, the KD Trey 5 X can help you float like KD, waiting for the perfect moment to drive to the hoop. A secure midfoot strap is suited for scoring binges and defensive stands, so that you can lock in and keep winning. This version is made for outdoor-court use with its extra-durable rubber outsole.",
                            Color = "Clear Jade/Sail/Vivid Sulphur/Geode Teal",
                            Style = "DJ7554-300",
                            Picture1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/e6a8d329-4a54-4ae9-bd96-35e247840e67/kd-trey-5-ep-basketball-shoes-mkllTG.png",
                            Picture2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/9c8a1a17-ef66-4231-9106-65ed5b71b9b8/kd-trey-5-ep-basketball-shoes-mkllTG.png",
                            Picture3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/591535e1-a282-4308-8e75-e5cdf7ffd288/kd-trey-5-ep-basketball-shoes-mkllTG.png",
                            Picture4 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/053069d5-d8ee-40e9-aae7-410a7a4708e8/kd-trey-5-ep-basketball-shoes-mkllTG.png",
                            Picture5 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/e69665fa-609f-48dd-b47d-d012be36b9b2/kd-trey-5-ep-basketball-shoes-mkllTG.png",
                            Picture6 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/be33b79b-a2e0-46a8-a9ad-9bdd4a57d088/kd-trey-5-ep-basketball-shoes-mkllTG.png"
                        },
                        new Product()
                        {
                            Name = "Nike Free Metcon 5",
                            ProductCategory = ProductCategory.Running,
                            Price = 539,
                            Description = "When your workouts wade into the nitty-gritty, the Nike Free Metcon 5 can meet you in the depths, help you dig deep to find that final ounce of force and come out of the other side on a high. It matches style with substance, forefoot flexibility with back-end stability, perfect for flying through a cardio day or enhancing your agility. A revamped upper offers easier entry with a collar made just for your ankle.",
                            Color = "University Red/White/Football Grey/Black",
                            Style = "DV3949-600",
                            Picture1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/8f46fbb6-fd83-46ad-8af3-c516d0f4a209/free-metcon-5-workout-shoes-7wNZNf.png",
                            Picture2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/9b2ac01d-e0c0-456c-b4c5-079373ce857f/free-metcon-5-workout-shoes-7wNZNf.png",
                            Picture3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/7aaafc2c-213e-442b-9d13-430190bbff24/free-metcon-5-workout-shoes-7wNZNf.png",
                            Picture4 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/28631f65-1602-4851-854e-4353b5b480bc/free-metcon-5-workout-shoes-7wNZNf.png",
                            Picture5 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/b42aba4c-62dd-471a-a400-d55dbf5a3d4d/free-metcon-5-workout-shoes-7wNZNf.png",
                            Picture6 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/15dc9d66-65d6-4560-89fd-6f4ab3994d36/free-metcon-5-workout-shoes-7wNZNf.png    "
                        },
                        new Product()
                        {
                            Name = "Nike React Gato",
                            ProductCategory = ProductCategory.Football,
                            Price = 579,
                            Description = "The Nike React Gato brings a new level of underfoot control and cushioning to the court. Flexible pods improve your feel on the ball and Nike React cushioning keeps you moving as you drag and cut across the court.",
                            Color = "Opti Yellow/Gum Light Brown/Black",
                            Style = "CT0550-700",
                            Picture1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/a6de1712-0d28-4ff8-ae94-4d28c4ace473/react-gato-indoor-court-low-top-football-shoes-pQBhgB.png",
                            Picture2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/d6c02034-a7ee-4a2c-95ea-7c2173dbbd01/react-gato-indoor-court-low-top-football-shoes-pQBhgB.png",
                            Picture3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/2319d5ac-b65a-4fc1-970e-484866158959/react-gato-indoor-court-low-top-football-shoes-pQBhgB.png",
                            Picture4 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/50473082-dba0-46b1-aec6-9bbeded4dd7e/react-gato-indoor-court-low-top-football-shoes-pQBhgB.png",
                            Picture5 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/8bc712bb-8797-4ad2-a501-99f31ba1aadd/react-gato-indoor-court-low-top-football-shoes-pQBhgB.png",
                            Picture6 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/59ab6119-1d55-41cb-9bf9-ed6857957714/react-gato-indoor-court-low-top-football-shoes-pQBhgB.png"
                        },
                        new Product()
                        {
                            Name = "Nike Phantom GX Club",
                            ProductCategory = ProductCategory.Football,
                            Price = 245,
                            Description = "Whether you're starting out or just playing for fun, the Club boot gets you on the pitch without compromising on quality. With synthetic leather and asymmetric lacing, they help provide precision touch to help you bury goals in the back of the net or set up a teammate with a pinpoint pass that swings the game in your favour.",
                            Color = "Black/Dark Smoke Grey/Total Orange/Summit White",
                            Style = "DD9483-010",
                            Picture1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/56ca5f8c-f577-4b08-a4fe-441fb3e2b9b2/phantom-gx-club-multi-ground-low-top-football-boot-WDxFP9.png",
                            Picture2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/0f1cce41-4f49-484a-bc5e-16f782c71b32/phantom-gx-club-multi-ground-low-top-football-boot-WDxFP9.png",
                            Picture3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/c1386cd4-d08c-40db-8a80-248999edfad4/phantom-gx-club-multi-ground-low-top-football-boot-WDxFP9.png",
                            Picture4 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/e0446015-2830-4a1e-a976-050b43e0820d/phantom-gx-club-multi-ground-low-top-football-boot-WDxFP9.png",
                            Picture5 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/0aaf967d-8583-469e-b023-49ffdfe2f97f/phantom-gx-club-multi-ground-low-top-football-boot-WDxFP9.png",
                            Picture6 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/5eac2b0d-4c79-4b35-aa5d-07cdb9eecf10/phantom-gx-club-multi-ground-low-top-football-boot-WDxFP9.png"
                        },
                        new Product()
                        {
                            Name = "Nike Zoom Fly 5",
                            ProductCategory = ProductCategory.Running,
                            Price = 759,
                            Description = "Bridge the gap between your weekend training and race day. The Nike Zoom Fly 5 can be deployed not just at the starting line of your favourite race, but in the days and months after your conquest. It offers comfort and reliability with a propulsive sensation that can help you feel fast and fresh. That kind of versatility is uncommon in the running arena. But who says you can't have it all?",
                            Color = "Luminous Green/Volt/Lime Blast/Black",
                            Style = "FQ8112-331",
                            Picture1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/778e4df5-2d66-404d-a6f2-b676df4298a1/zoom-fly-5-road-running-shoes-hPrw3h.png",
                            Picture2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/0f99f2ce-ef5e-42d1-a28c-1dd8f2316774/zoom-fly-5-road-running-shoes-hPrw3h.png",
                            Picture3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/7a3f88b7-7958-4277-b910-912580381c4c/zoom-fly-5-road-running-shoes-hPrw3h.png",
                            Picture4 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/fd504984-08b6-4cf9-8d02-44eca8af74f1/zoom-fly-5-road-running-shoes-hPrw3h.png",
                            Picture5 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/0803f107-7437-4e58-9151-88be4be864e2/zoom-fly-5-road-running-shoes-hPrw3h.png",
                            Picture6 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/0c4649ba-faab-4bf5-bbe4-36dabef50959/zoom-fly-5-road-running-shoes-hPrw3h.png"
                        },
                        new Product()
                        {
                            Name = "Nike SB Force 58",
                            ProductCategory = ProductCategory.Lifestyle,
                            Price = 329,
                            Description = "The latest and greatest innovation to hit the streets, the Nike SB Force 58 Premium gives you the durability of a cupsole with the flexibility of a vulcanised shoe.Made from soft, supple leather and finished with perforations, the whole look is infused with heritage basketball DNA.",
                            Color = "White/White/White/Black",
                            Style = "DH7505-101",
                            Picture1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/58b6dc02-0901-45b5-8ddd-50db2891fb0f/sb-force-58-skate-shoe-DvWCT6.png",
                            Picture2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/0608afa3-02cc-4ccd-ae5a-660ae345bac4/sb-force-58-skate-shoe-DvWCT6.png",
                            Picture3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/3e440a4b-e1a1-4684-8fdf-baaca088cc5d/sb-force-58-skate-shoe-DvWCT6.png",
                            Picture4 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/456693c0-9c22-4ca0-bfa0-7e827ecfe707/sb-force-58-skate-shoe-DvWCT6.png",
                            Picture5 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/40102a2d-cf35-4ab6-85b4-3a0ca74b8cf4/sb-force-58-skate-shoe-DvWCT6.png",
                            Picture6 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/1fd0d33c-8e6c-412a-aba4-914f7edcd9a4/sb-force-58-skate-shoe-DvWCT6.png"
                        },
                        new Product()
                        {
                            Name = "Nike Tiempo Legend 10",
                            ProductCategory = ProductCategory.Football,
                            Price = 355,
                            Description = "Even Legends find ways to evolve. Made to take your game to the next level, the latest iteration of this Academy boot has all-new FlyTouch Lite engineered leather. Softer than natural leather, it contours to your foot and doesn't overstretch, so you can dictate the pace of your game. Lighter and sleeker than any other Tiempo to date, the Legend 10 is for any position on the pitch, whether you're sending a pinpoint pass through the defence or tracking back to stop a break-away.",
                            Color = "Hyper Turquoise/Fuchsia Dream/Black",
                            Style = "DV4337-300",
                            Picture1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/ad350394-404f-4e9a-80ac-7a6090d31fe2/tiempo-legend-10-academy-multi-ground-low-top-football-boot-gthDNJ.png",
                            Picture2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/5668bd15-cb20-447e-8556-002cec8baeef/tiempo-legend-10-academy-multi-ground-low-top-football-boot-gthDNJ.png",
                            Picture3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/aaae0cf2-910b-4756-8633-60881b704e2d/tiempo-legend-10-academy-multi-ground-low-top-football-boot-gthDNJ.png",
                            Picture4 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/159737e4-4d02-4272-85a0-109e75817a57/tiempo-legend-10-academy-multi-ground-low-top-football-boot-gthDNJ.png",
                            Picture5 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/cdeae081-500e-4982-9ab2-12a5a569ce99/tiempo-legend-10-academy-multi-ground-low-top-football-boot-gthDNJ.png",
                            Picture6 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/45ad2025-21a7-48a5-ba29-b92842df06a9/tiempo-legend-10-academy-multi-ground-low-top-football-boot-gthDNJ.png"
                        },
                        new Product()
                        {
                            Name = "Giannis Immortality 3 EP",
                            ProductCategory = ProductCategory.Basketball,
                            Price = 355,
                            Description = "How do you want your game to be remembered? Preserve your place among the greats, like Giannis, in the Giannis Immortality 3. Mindfully made for today's high-paced, position-less game, it's softer than the previous iteration with a specific traction pattern that's perfect for pulling off the perfect Euro step en route to glory. With its extra-durable rubber outsole, this version gives you traction for outdoor courts.",
                            Color = "Noble Red/Desert Berry/Medium Soft Pink/Ice Peach",
                            Style = "DZ7534-600",
                            Picture1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/f4070a60-1447-483a-b62a-7ffd609844e1/giannis-immortality-3-ep-basketball-shoes-0dTCk5.png",
                            Picture2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/d175cc91-6357-4082-9084-258596904849/giannis-immortality-3-ep-basketball-shoes-0dTCk5.png",
                            Picture3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/7b177512-7408-4c86-b7f2-3dc6dc4b703a/giannis-immortality-3-ep-basketball-shoes-0dTCk5.png",
                            Picture4 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/53cd5be5-4303-4f8d-9079-d5f230f39e0c/giannis-immortality-3-ep-basketball-shoes-0dTCk5.png",
                            Picture5 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/b4086f86-be1d-40e6-a8ac-251c96479f76/giannis-immortality-3-ep-basketball-shoes-0dTCk5.png",
                            Picture6 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/2d838a58-7ef6-436b-a854-7f9951e3e1cc/giannis-immortality-3-ep-basketball-shoes-0dTCk5.png"
                        },
                        new Product()
                        {
                            Name = "LeBron XXI 'Dragon Pearl' EP",
                            ProductCategory = ProductCategory.Basketball,
                            Price = 909,
                            Description = "Last time around, LeBron flipped the script on his shoe game as only the King can. The encore is even better. The LeBron XXI has a cabling system that works with Zoom Air cushioning and a light, low-to-the-ground design, giving you agile fluidity and explosiveness without excess weight. Created for your ascent and the next generation of hoopers, it's ideal for Bron-like open-floor attacks and rising towards the rim when the game's pace turns up. This special design celebrates the most valuable pearl in the world, the dragon pearl. With its extra-durable rubber outsole, this version gives you traction for outdoor courts.",
                            Color = "Melon Tint/Metallic Red Bronze/Monarch",
                            Style = "FV2346-800",
                            Picture1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/7a243361-5804-41fe-913e-7b6c9523f806/lebron-xxi-dragon-pearl-ep-basketball-shoes-4tVgfH.png",
                            Picture2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/90ee19d9-7128-45cf-a842-d8684b6a854f/lebron-xxi-dragon-pearl-ep-basketball-shoes-4tVgfH.png",
                            Picture3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/7e361ff4-7616-46a5-99c6-414b7edd3ea2/lebron-xxi-dragon-pearl-ep-basketball-shoes-4tVgfH.png",
                            Picture4 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/6dc65fed-ef0c-467a-bc20-4d31386216d1/lebron-xxi-dragon-pearl-ep-basketball-shoes-4tVgfH.png",
                            Picture5 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/d948d8f2-6f16-4dc0-b5d9-67040c37b886/lebron-xxi-dragon-pearl-ep-basketball-shoes-4tVgfH.png",
                            Picture6 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/f0392794-560b-42fb-ae03-80e0f25d5f08/lebron-xxi-dragon-pearl-ep-basketball-shoes-4tVgfH.png"
                        },
                        new Product()
                        {
                            Name = "Nike Air Humara",
                            ProductCategory = ProductCategory.Lifestyle,
                            Price = 709,
                            Description = "The Air Humara sets you up with vintage ACG aesthetics and Nike trail running DNA. Made from quality materials with a whole lot of outdoor appeal, everything about this shoe encapsulates the '90s zeitgeist. Its textile-wrapped midsole puts you a step ahead of the rest, while Zoom Air in the forefoot and Nike Air in the heel deliver legendary cushioning so you can stay untameable.",
                            Color = "Black/Bright Crimson/Total Orange/Black",
                            Style = "FJ7109-001",
                            Picture1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/12a4582a-31e3-4438-b9f1-1aec9991314a/air-humara-shoes-cMxm2B.png",
                            Picture2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/74d54c13-31b6-4e0e-9334-43628d81ebb3/air-humara-shoes-cMxm2B.png",
                            Picture3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/389936ac-52f6-4d0e-824a-9f0b94991aab/air-humara-shoes-cMxm2B.png",
                            Picture4 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/cfb4b57a-7c44-425e-9010-7dc6b8a996f4/air-humara-shoes-cMxm2B.png",
                            Picture5 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/0115b8bb-59c6-408b-8c8a-77ad0a28a47d/air-humara-shoes-cMxm2B.png",
                            Picture6 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/8f828c89-78b9-49c3-abf1-0f6f666b247f/air-humara-shoes-cMxm2B.png"
                        },
                        new Product()
                        {
                            Name = "Nike Vomero 17 PRM",
                            ProductCategory = ProductCategory.Running,
                            Price = 759,
                            Description = "A springy and soft ride to energise every mile, the Vomero 17 takes you to your running happy place. Its stacked foam provides premium responsiveness to help you kick it up a notch when you're ready for that extra gear. And with across-the-board enhancements that deliver a new level of lightweight comfort and breathability, this shoe is for those road runners who seek the thrill of the vroom and the kind of plush feel that puts you in cruise control for short-to-long distances. This special design pays homage to the attention-gabbling silent supporters among the crowd, the life-saving pit stops that provide both relief and peace on your path.",
                            Color = "Teal Nebula/Laser Orange/Earth/White",
                            Style = "FN4268-300",
                            Picture1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/380531ff-1439-4ebc-9f7c-5fd0ed4083f6/vomero-17-prm-road-running-shoes-cmjrZ2.png",
                            Picture2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/49bd261b-1762-4ce8-94ff-e4dd6e2552a8/vomero-17-prm-road-running-shoes-cmjrZ2.png",
                            Picture3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/82f2ad6f-6f13-4199-90dd-a1a420b87777/vomero-17-prm-road-running-shoes-cmjrZ2.png",
                            Picture4 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/2f76936c-5d9b-42c9-85b6-b57802a26ca2/vomero-17-prm-road-running-shoes-cmjrZ2.png",
                            Picture5 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/6c7a757f-2a27-49b6-949f-30690f8f571a/vomero-17-prm-road-running-shoes-cmjrZ2.png",
                            Picture6 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/ebfeb1be-b0f0-4f74-aad1-ade2f48fe7ff/vomero-17-prm-road-running-shoes-cmjrZ2.png"
                        },
                    });
                    context.SaveChanges();                    
                }
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                // Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                // Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@sporta.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin",
                        UserName = "admin",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Admin@12345");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@sporta.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "User",
                        UserName = "user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "User@12345");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
