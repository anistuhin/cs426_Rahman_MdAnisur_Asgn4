## CS426 Assignment 4

**Project Name:** CatMail

**Author:** Md Anisur Rahman

**Brief game idea:** The basic story-line of the game is to collect/buy necessary items to build a PC. I send a cat acting as a player who shops for the items on behalf of me and after collecting the enough PC parts, deliver them to me so that I can build PCs. This way we learn the names of some of the very important parts to build a PC.

**Player Interaction Pattern:** Player vs game, Single Player

**Objective:** Collect as many objects (PC parts) as I can to score points and win the game. I'm using the cat as a player who collects the PC part items for me and that aligns with the game theme
 
**Serious Objective:** To learn some of the very important PC parts names that are generally required to build a PC

**Procedures:**  
*Start Game Button:* To start the game  
*Key "W":* To move forward 
*Key "S":* To move backward  
*Key "A":* To rotate the view/environment towards left  
*Key "D":* To rotate the view/environment towards right  
*Collide with the boxes:* to collect them as PC parts and win scores/game
*Avoid colliding with the yellow poles:* to avoid damaging parts and so decremting scores

**Rules:**
1. The cat must collect at least 5 items to achieve the goal of building a PC
2. The cat must not collide with the yellow poles because that damages the collected parts, hence hurting the scores obtained (unusual rule)

**Resources:**
Different PC parts i.e. RAM, CPU, Hard Drives, Power Supply, Monitor, Keyboard, Mouse, Motherboard, Printer, Scanner etc

**Test Question for Serious Objective:** What are some of the major PC parts we usually need to build a PC?

**Expected Correct Answer for Serious Objective:** RAM, CPU, Hard Drives, Power Supply, Monitor, Keyboard, Mouse, Motherboard, Printer, Scanner etc

**Creedits:**
1. https://assetstore.unity.com/packages/3d/characters/animals/mammals/free-chibi-cat-165490
2. https://assetstore.unity.com/packages/3d/environments/sci-fi/adventure-game-environment-pack-urp-246189




**Addressing the deliverables**
1. Enhanced the gamae by fixing the player jumping on collision issue, adding decrementing scores on collision to yellow poles, hence the unusual rules now works
2. Added/replicated a few physics constructs like adding collisionns to yellow poles and decrementing scores as well as destryoying them to avoid redundancies, adding collissions with other still objects like vase, crates and not make  the main character keep flying(error from HW2) from HW2 as replication is allowed and also fixed the collision issue to make the unusual rules work
3. Added one more billboard stating the game rules laong with the previous one witht eh serious question
4. Added spotlosights on each of those billboards t attract attentions, added colors too
