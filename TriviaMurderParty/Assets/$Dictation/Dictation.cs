using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using KModkit;

public class Dictation : MonoBehaviour {

    public KMBombInfo Bomb;
    public KMAudio Audio;
    public KMSelectable[] SmallAssholes;
    public KMSelectable BackAssCrack;
    public KMSelectable Lefttard;
    public TextMesh TacoBell;
    public TextMesh AidsMongerer;
    public GameObject Penis;
    public Material[] Penises;

    int fuck;
    int Ineedtopiss;
    int Peepee;
    int weed;
    int ineedanother;

    float Fanfare;
    float NumAids = 0.05f;

    string Namtar = "QWERTYUIOPASDFGHJKLZXCVBNM<";
    private string[][] Aids = new string[43][] {
      new string[99]{"I" , "AM" , "SO" , "SORRY" , "FOR" , "BEING" , "AGGRESSIVE" , "ON" , "THE" , "TUTORIAL" , "I" , "dont" , "understand" , "how" , "it" , "worked" , "like" , "that" , "bus" , "was" , "way" , "too" , "scary" , "for" , "me" , "to" , "watch" , "and" , "I" , "just" , "felt" , "like" , "I" , "dont" , "know" , "what" , "I" , "am" , "watching" , "anymore" , "ACTUALLY" , "FUCK" , "IT" , "IM" , "MAD" , "I" , "GOT" , "GROUNDED" , "AFTER" , "I" , "PUNCHED" , "A" , "WHOLE" , "IN" , "MY" , "WALL" , "AFTER" , "WATCHING" , "YOUR" , "TUTORIALS" , "I" , "sorry" , "I" , "need" , "to" , "take" , "drugs" , "just" , "like" , "mom" , "says" , "and" , "no" , "more" , "Dr" , "Pepper" , "That" , "was" , "mean" , "and" , "I" , "dont" , "understand" , "it" , "please" , "make" , "sure" , "to" , "remake" , "this" , "tutorial" , "just" , "like" , "all" , "of" , "your" , "other" , "tutorials" , "Bye"},
      new string[64]{"Dear" , "loyal" , "subscribers" , "I" , "need" , "to" , "apologize" , "for" , "what" , "I" , "did" , "I" , "am" , "sorry" , "for" , "saying" , "you" , "cant" , "see" , "me" , "while" , "at" , "a" , "school" , "for" , "the" , "blind" , "The" , "goal" , "of" , "my" , "content" , "is" , "always" , "to" , "entertain" , "Im" , "sorry" , "for" , "not" , "feeding" , "my" , "dogs" , "for" , "a" , "week" , "just" , "so" , "I" , "could" , "film" , "them" , "eating" , "each" , "other" , "The" , "goal" , "of" , "my" , "content" , "is" , "always" , "to" , "entertain"},
      new string[94]{"Hello" , "Hello" , "hello" , "Uh" , "I" , "wanted" , "to" , "record" , "a" , "message" , "for" , "you" , "to" , "help" , "you" , "get" , "settled" , "in" , "on" , "your" , "first" , "night" , "Um" , "I" , "actually" , "worked" , "in" , "that" , "office" , "before" , "you" , "Im" , "finishing" , "up" , "my" , "last" , "week" , "now" , "as" , "a" , "matter" , "of" , "fact" , "so" , "I" , "know" , "it" , "can" , "be" , "a" , "little" , "overwhelming" , "but" , "Im" , "here" , "to" , "tell" , "you" , "theres" , "nothing" , "to" , "worry" , "about" , "uhh" , "youll" , "do" , "fine" , "So" , "lets" , "just" , "focus" , "on" , "getting" , "you" , "through" , "your" , "first" , "week" , "Ok" , "Uh" , "lets" , "see" , "First" , "theres" , "an" , "introductory" , "greeting" , "from" , "the" , "company" , "Im" , "supposed" , "to" , "read"},
      new string[32]{"Dear" , "Weird" , "Al" , "Yankovic" , "shut" , "the" , "fuck" , "up" , "i" , "will" , "fucking" , "lazer" , "you" , "with" , "alien" , "fucking" , "eyes" , "and" , "explode" , "your" , "fucking" , "head" , "Shut" , "the" , "fuck" , "try" , "to" , "write" , "a" , "rap" , "Ok" , "then"},
      new string[65]{"Dear" , "Liberals" , "I" , "made" , "a" , "severe" , "and" , "continuous" , "lapse" , "in" , "my" , "judgement" , "and" , "I" , "dont" , "expect" , "to" , "be" , "forgiven" , "Im" , "simply" , "here" , "to" , "apologize" , "What" , "we" , "came" , "across" , "that" , "day" , "in" , "the" , "woods" , "was" , "obviously" , "unplanned" , "The" , "reactions" , "you" , "saw" , "on" , "tape" , "were" , "raw" , "they" , "were" , "unfiltered" , "None" , "of" , "us" , "knew" , "how" , "to" , "react" , "or" , "how" , "to" , "feel" , "I" , "should" , "have" , "never" , "posted" , "the" , "video"},
      new string[69]{"Dear" , "Conservatives" , "It" , "has" , "not" , "been" , "easy" , "for" , "me" , "It" , "has" , "not" , "been" , "easy" , "for" , "me" , "I" , "started" , "off" , "in" , "Brooklyn" , "My" , "father" , "gave" , "me" , "a" , "small" , "loan" , "of" , "a" , "million" , "dollars" , "I" , "came" , "into" , "Manhattan" , "and" , "I" , "had" , "to" , "pay" , "him" , "back" , "and" , "I" , "had" , "to" , "pay" , "him" , "back" , "with" , "interest" , "But" , "I" , "came" , "into" , "Manhattan" , "and" , "I" , "started" , "buying" , "properties" , "and" , "I" , "did" , "great" , "Sincerely" , "Bill" , "Clinton"},
      new string[32]{"Dear" , "Local" , "News" , "Broadcasting" , "Team" , "I" , "have" , "punched" , "a" , "small" , "child" , "between" , "the" , "eyes" , "and" , "he" , "became" , "blind" , "I" , "would" , "like" , "to" , "say" , "Im" , "sorry" , "for" , "my" , "actions" , "that" , "day" , "Sincerely" , "God"},
      new string[65]{"Hello" , "there" , "everyone" , "my" , "name" , "is" , "Crazy" , "Caleb" , "and" , "today" , "we" , "will" , "be" , "taking" , "a" , "look" , "at" , "my" , "wife" , "The" , "Jewel" , "Vault" , "So" , "for" , "those" , "of" , "you" , "who" , "are" , "new" , "to" , "the" , "channel" , "I" , "have" , "an" , "obsession" , "with" , "this" , "module" , "and" , "I" , "have" , "never" , "struck" , "on" , "it" , "ever" , "Thank" , "you" , "guys" , "for" , "watching" , "and" , "remember" , "to" , "Stay" , "Crazy" , "Stay" , "Cool" , "See" , "you" , "guys" , "next" , "time"},
      new string[46]{"League" , "of" , "Legends" , "is" , "truly" , "a" , "fun" , "game" , "sometimes" , "One" , "of" , "the" , "best" , "times" , "is" , "playing" , "as" , "Blitzcrank" , "where" , "you" , "can" , "hook" , "people" , "over" , "walls" , "and" , "bring" , "them" , "back" , "for" , "easy" , "kills" , "It" , "really" , "makes" , "you" , "feel" , "like" , "youre" , "impacting" , "the" , "game" , "without" , "needing" , "crazy" , "mechanics"},
      new string[84]{"I" , "was" , "nervous" , "the" , "first" , "time" , "but" , "then" , "again" , "I" , "think" , "everyone" , "is" , "It" , "was" , "one" , "thing" , "to" , "do" , "this" , "alone" , "practicing" , "in" , "my" , "room" , "but" , "another" , "when" , "someone" , "else" , "is" , "there" , "There" , "was" , "so" , "much" , "to" , "think" , "about" , "rhythm" , "pace" , "mood" , "working" , "ones" , "way" , "up" , "to" , "the" , "crescendo" , "but" , "not" , "too" , "quickly" , "I" , "worried" , "I" , "wouldnt" , "be" , "able" , "to" , "perform" , "but" , "she" , "made" , "me" , "feel" , "so" , "comfortable" , "and" , "relaxed" , "It" , "was" , "then" , "that" , "I" , "knew" , "I" , "could" , "DJ" , "for" , "any" , "number" , "of" , "people"},
      new string[46]{"Please" , "help" , "I" , "tried" , "to" , "put" , "my" , "dick" , "in" , "a" , "Black" , "Hole" , "module" , "and" , "now" , "its" , "stuck" , "I" , "cant" , "move" , "oh" , "god" , "This" , "really" , "gives" , "a" , "new" , "meaning" , "to" , "blowing" , "up" , "haha" , "Help" , "it" , "hurts" , "I" , "dont" , "wanna" , "die" , "like" , "this" , "please" , "someone" , "help" , "why" , "me"},
      new string[29]{"The" , "moderation" , "team" , "has" , "seen" , "you" , "telling" , "people" , "to" , "shut" , "the" , "fuck" , "up" , "in" , "text" , "chats" , "We" , "do" , "not" , "tolerate" , "that" , "aggression" , "You" , "are" , "being" , "given" , "your" , "second" , "warning"},
      new string[46]{"Write" , "a" , "few" , "sentences" , "about" , "anything" , "as" , "long" , "as" , "the" , "total" , "message" , "length" , "isnt" , "above" , "one", "hundred" , "words" , "and" , "the" , "sentences" , "are" , "coherent" , "Swearing" , "is" , "allowed" , "although" , "please" , "make" , "it" , "minimal" , "Your" , "name" , "will" , "not" , "be" , "recorded" , "but" , "I" , "ask" , "so" , "I" , "dont" , "get" , "unwanted" , "duplicates"},
      new string[45]{"I" , "am" , "done" , "I" , "am" , "through" , "I" , "am" , "just" , "sick" , "of" , "it" , "all" , "I" , "am" , "tired" , "of" , "the" , "feeders" , "in" , "my" , "stupid" , "game" , "of" , "LoL" , "Uninstall" , "right" , "away" , "with" , "your" , "zero" , "sixteen" , "four" , "Youre" , "the" , "reason" , "why" , "I" , "never" , "want" , "to" , "play" , "this" , "any" , "more"},
      new string[51]{"A" , "grid" , "on" , "this" , "module" , "with" , "four" , "by" , "four" , "squares" , "shows" , "images" , "letters" , "and" , "other" , "affairs" , "The" , "goals" , "to" , "decode" , "what" , "the" , "cell" , "values" , "mean" , "then" , "solve" , "a" , "Sudoku" , "to" , "turn" , "the" , "light" , "green" , "The" , "answers" , "are" , "also" , "submitted" , "in" , "code" , "Just" , "get" , "them" , "all" , "right" , "and" , "you" , "will" , "not" , "explode"},
      new string[74]{"Were" , "no" , "strangers" , "to" , "love" , "You" , "know" , "the" , "rules" , "and" , "so" , "do" , "I" , "A" , "full" , "commitments" , "what" , "Im" , "thinking" , "of" , "You" , "wouldnt" , "get" , "this" , "from" , "any" , "other" , "guy" , "I" , "just" , "wanna" , "tell" , "you" , "how" , "Im" , "feeling" , "Gotta" , "make" , "you" , "understand" , "Never" , "gonna" , "give" , "you" , "up" , "Never" , "gonna" , "let" , "you" , "down" , "Never" , "gonna" , "run" , "around" , "and" , "desert" , "you" , "Never" , "gonna" , "make" , "you" , "cry" , "Never" , "gonna" , "say" , "goodbye" , "Never" , "gonna" , "tell" , "a" , "lie" , "and" , "hurt" , "you"},
      new string[29]{"Okay" , "it" , "started" , "Its" , "just" , "cycling" , "through" , "a" , "bunch" , "of" , "words" , "Am" , "I" , "supposed" , "to" , "be" , "reading" , "these" , "Oh" , "shit" , "I" , "missed" , "a" , "word" , "hang" , "on" , "alright" , "thats" , "it"},
      new string[3]{"Weed" , "Chungus" , "Unicorn"},
      new string[100]{"Words" , "cannot" , "describe" , "how" , "much" , "I" , "LOVE" , "Reddit" , "Its" , "such" , "a" , "fun" , "social" , "media" , "hangout" , "where" , "I" , "could" , "laugh" , "at" , "other" , "people" , "for" , "having" , "an" , "incorrect" , "opinion" , "Whats" , "that" , "You" , "like" , "children" , "being" , "happy" , "No" , "no" , "no" , "no" , "no" , "we" , "cannot" , "have" , "that" , "I" , "will" , "now" , "proceed" , "to" , "bombshell" , "spam" , "you" , "with" , "Keanu" , "Reeves" , "and" , "Big" , "Chungus" , "saying" , "that" , "you" , "suck" , "as" , "a" , "human" , "being" , "You" , "are" , "such" , "a" , "disappointment" , "to" , "the" , "face" , "of" , "this" , "earth" , "that" , "you" , "should" , "delete" , "your" , "Reddit" , "account" , "I" , "will" , "then" , "proceed" , "to" , "get" , "Reddit" , "gold" , "because" , "I" , "said" , "Big" , "Chungus" , "I" , "love" , "the" , "internet"},
      new string[100]{"I" , "attest" , "to" , "the" , "following" , "I" , "shall" , "not" , "give" , "or" , "receive" , "aid" , "during" , "this" , "exam" , "My" , "answers" , "will" , "be" , "entirely" , "my" , "own" , "Plagiarism" , "software" , "will" , "scan" , "my" , "responses" , "If" , "I" , "give" , "or" , "receive" , "help" , "or" , "submit" , "work" , "that" , "is" , "not" , "my" , "own" , "My" , "score" , "will" , "be" , "canceled" , "My" , "attempt" , "to" , "cheat" , "will" , "be" , "reported" , "to" , "college" , "admissions" , "offices" , "and" , "my" , "high" , "school" , "I" , "will" , "be" , "banned" , "from" , "future" , "college" , "board" , "exams" , "Anyone" , "who" , "helps" , "me" , "or" , "receives" , "help" , "from" , "me" , "will" , "be" , "investigated" , "My" , "grandfather" , "picks" , "up" , "quartz" , "and" , "valuable" , "onyx" , "jewels" , "Send" , "sixty" , "dozen" , "quart" , "jars" , "and" , "black" , "pans"},
      new string[51]{"two" , "two" , "four" , "two" , "seven" , "equals" , "eight" , "one" , "four" , "eight" , "ten" , "five" , "equals" , "four" , "three" , "twenty" , "two" , "eighteen" , "seven" , "six" , "equals" , "two" , "six" , "fifteen" , "eight" , "six" , "two" , "equals" , "four" , "ten" , "nine" , "three" , "fifteen" , "four" , "equals" , "two" , "red" , "equals" , "four" , "green" , "equals" , "two" , "blue" , "equals" , "six" , "orange" , "equals" , "five" , "pink" , "equals" , "six"},
      new string[64]{"A" , "Simon" , "Sends" , "puzzle" , "is" , "equipped" , "with" , "colorized" , "lights" , "which" , "flash" , "unique" , "letters" , "in" , "Morse" , "code" , "simultaneously" , "and" , "a" , "dial" , "for" , "adjusting" , "the" , "frequency" , "of" , "flashing" , "Owing" , "to" , "their" , "proximity" , "the" , "lights" , "mix" , "by" , "way" , "of" , "additive" , "color" , "mixing" , "Work" , "out" , "the" , "individual" , "colors" , "Convert" , "each" , "recognized" , "letter" , "into" , "a" , "number" , "using" , "its" , "alphabetic" , "position" , "Call" , "your" , "thusly" , "acquired" , "numbers" , "R" , "G" , "and" , "B"},
      new string[100]{"Of" , "course" , "he" , "did" , "How" , "could" , "it" , "be" , "otherwise" , "Scrooge" , "and" , "he" , "were" , "partners" , "for" , "I" , "dont" , "know" , "how" , "many" , "years" , "Scrooge" , "was" , "his" , "sole" , "executor" , "his" , "sole" , "administrator" , "his" , "sole" , "assign" , "his" , "sole" , "residuary" , "legatee" , "his" , "sole" , "friend" , "and" , "sole" , "mourner" , "And" , "even" , "Scrooge" , "was" , "not" , "so" , "dreadfully" , "cut" , "up" , "by" , "the" , "sad" , "event" , "but" , "that" , "he" , "was" , "an" , "excellent" , "man" , "of" , "business" , "on" , "the" , "very" , "day" , "of" , "the" , "funeral" , "and" , "solemnised" , "it" , "with" , "an" , "undoubted" , "bargain" , "The" , "mention" , "of" , "Marleys" , "funeral" , "brings" , "me" , "back" , "to" , "the" , "point" , "I" , "started" , "from" , "There" , "is" , "no" , "doubt" , "that" , "Marley" , "was" , "dead"},
      new string[64]{"Hi" , "Danny" , "Seven" , "Thousand" , "Seven" , "The" , "KTaNE" , "server" , "staff" , "has" , "seen" , "you" , "recently" , "react" , "to" , "a" , "hashtag" , "mods" , "major" , "post" , "with" , "reactions" , "that" , "break" , "our" , "server" , "rules" , "namely" , "the" , "ones" , "that" , "spell" , "cringe" , "with" , "this" , "emoji" , "nauseated" , "face" , "The" , "staff" , "team" , "have" , "decided" , "to" , "remove" , "ban" , "you" , "from" , "the" , "server" , "for" , "one" , "week" , "Once" , "the" , "week" , "is" , "up" , "you" , "should" , "be" , "able" , "to" , "rejoin"},
      new string[49]{"Its" , "time" , "for" , "the" , "attack" , "When" , "you" , "see" , "two" , "clues" , "that" , "match" , "buzz" , "in" , "Ill" , "give" , "you" , "cash" , "if" , "you" , "get" , "right" , "but" , "youll" , "owe" , "me" , "if" , "its" , "wrong" , "Not" , "all" , "words" , "are" , "gonna" , "be" , "a" , "match" , "Remember" , "The" , "Clue" , "Its" , "gotta" , "be" , "a" , "match" , "that" , "fits" , "this" , "clue"},
      new string[98]{"so" , "guys" , "we" , "did" , "it" , "we" , "reached" , "a" , "quarter" , "of" , "a" , "million" , "subscribers" , "two" , "hundred" , "and" , "fifty" , "thousand" , "subscribers" , "and" , "still" , "growing" , "the" , "fact" , "that" , "we" , "reached" , "this" , "number" , "in" , "such" , "a" , "short" , "amount" , "of" , "time" , "is" , "just" , "phenomenal" , "im" , "just" , "amazed" , "thank" , "you" , "all" , "so" , "much" , "for" , "supporting" , "this" , "channel" , "and" , "helping" , "it" , "grow" , "I" , "love" , "you" , "guys" , "you" , "guys" , "are" , "just" , "awesome" , "so" , "as" , "you" , "can" , "probably" , "tell" , "this" , "isnt" , "really" , "a" , "montage" , "parody" , "this" , "is" , "really" , "more" , "like" , "a" , "kind" , "thank" , "you" , "update" , "video" , "so" , "in" , "this" , "video" , "im" , "quickly" , "gonna" , "go" , "over" , "two" , "things"},
      new string[96]{"They" , "say" , "your" , "father" , "was" , "a" , "great" , "man" , "you" , "must" , "be" , "whats" , "left" , "Need" , "to" , "stop" , "hatin" , "on" , "gays" , "let" , "em" , "teach" , "you" , "how" , "to" , "dress" , "Youve" , "got" , "the" , "momma" , "jeans" , "and" , "a" , "Mister" , "Fantastic" , "face" , "So" , "rich" , "and" , "white" , "its" , "like" , "Im" , "running" , "against" , "a" , "cheesecake" , "Republicans" , "need" , "a" , "puppet" , "and" , "you" , "fit" , "Got" , "their" , "hands" , "so" , "far" , "up" , "your" , "rear" , "call" , "you" , "Mitt" , "Im" , "the" , "head" , "of" , "state" , "youre" , "like" , "a" , "head" , "of" , "cabbage" , "Bout" , "to" , "get" , "smacked" , "by" , "my" , "stimulus" , "package" , "Youre" , "a" , "bad" , "man" , "with" , "no" , "chance" , "you" , "cant" , "even" , "touch" , "me"},
      new string[70]{"Oh" , "my" , "god" , "what" , "the" , "hell" , "whats" , "going" , "on" , "What" , "oh" , "my" , "god" , "Coke" , "are" , "you" , "serious" , "right" , "now" , "COKE" , "GAMING" , "WHAT" , "You" , "are" , "invited" , "to" , "the" , "Twitch" , "Partner" , "Program" , "HI" , "I" , "Just" , "got" , "partnered" , "We" , "got" , "partnered" , "boys" , "AHHHHHHHHHHH" , "What" , "Coke" , "Gaming" , "what" , "Is" , "this" , "Ten" , "thousand" , "bits" , "Coke" , "Gaming" , "thank" , "you" , "so" , "much" , "for" , "the" , "ten" , "thousand" , "bits" , "Thanks" , "Thank" , "you" , "Thank" , "you" , "so" , "much" , "Thank" , "you" , "Coke"},
      new string[97]{"In" , "the" , "future" , "entertainment" , "will" , "be" , "randomly" , "generated" , "randomly" , "generated" , "randomly" , "generated" , "what" , "better" , "way" , "to" , "achieve" , "the" , "unexpected" , "Ive" , "seen" , "the" , "future" , "bob" , "and" , "the" , "future" , "is" , "autotainment" , "hi" , "rusty" , "hi" , "ventrilomatic" , "hi" , "Larry" , "hi" , "Bob" , "greetings" , "hey" , "those" , "are" , "robots" , "affirmative" , "not" , "only" , "that" , "but" , "these" , "guys" , "represent" , "the" , "host" , "of" , "the" , "future" , "unlike" , "us" , "their" , "humor" , "can" , "be" , "randomly" , "generated" , "right" , "guys" , "why" , "did" , "the" , "chicken" , "cross" , "the" , "road" , "I" , "dont" , "know" , "why" , "did" , "the" , "chicken" , "cross" , "the" , "road" , "Weed" , "eater" , "now" , "that" , "funny" , "that" , "doesnt" , "make" , "any" , "sense" , "its" , "funny" , "because" , "its" , "unexpected"},
      new string[48]{"The" , "Pacer" , "FitnessGram" , "Test" , "is" , "multistage" , "a" , "aerobic" , "capacity" , "that" , "test" , "progressively" , "gets" , "difficult" , "more" , "as" , "it" , "continues" , "The" , "meter" , "twenty" , "pacer" , "test" , "begin" , "will" , "in" , "thirty" , "seconds" , "Line" , "at" , "up" , "the" , "start" , "The" , "speed" , "running" , "starts" , "slowly" , "gets" , "but" , "faster" , "each" , "after" , "minute" , "you" , "this" , "hear" , "signal"},
      new string[34]{"Wait" , "was" , "that" , "the" , "letter" , "Echo" , "or" , "the" , "word" , "E" , "you" , "say" , "as" , "you" , "are" , "baffled" , "befuddled" , "and" , "bemused" , "This" , "module" , "will" , "beguile" , "and" , "buffalo" , "and" , "bewilder" , "to" , "make" , "sure" , "it" , "is" , "never" , "defused"},
      new string[29]{"Ill" , "have" , "two" , "number" , "nines" , "a" , "number" , "nine" , "large" , "a" , "number" , "six" , "with" , "extra" , "dip" , "a" , "number" , "seven" , "two" , "number" , "forty" , "fives" , "one" , "with" , "cheese" , "and" , "a" , "large" , "soda"},
      new string[36]{"HI" , "IM" , "GUY" , "FIERI" , "I" , "AM" , "SHOUTING" , "FROM" , "A" , "CAR" , "ABOUT" , "A" , "NICE" , "RESTAURANT" , "Guy" , "drives" , "whilst" , "wearing" , "sunglasses" , "He" , "informs" , "you" , "that" , "he" , "is" , "rolling" , "out" , "to" , "find" , "Americas" , "best" , "Diners" , "Drive" , "ins" , "and" , "Dives"},
      new string[26]{"You", "are", "great", "When", "is", "your", "violin", "concert", "June", "fifteenth", "Whats", "the", "day", "today", "June", "eleventh", "Oh","this","Friday","Can","you","come","to","my","concert","Sure"},
      new string[26]{"Can" , "you" , "do" , "Red" , "Cipher" , "Can" , "you" , "do" , "Bamboozled" , "Again" , "Can" , "you" , "do" , "misery" , "squares" , "You" , "will" , "get" , "bamboozled" , "and" , "have" , "to" , "do" , "the" , "Luna" , "Platurion"},
      new string[44]{"THE" , "SECURITY" , "SYSTEM" , "TAKES" , "CONTROL" , "OF" , "SQUIDWARDS" , "HOUSE" , "AND" , "BEGINS" , "ATTACKING" , "THE" , "CITY" , "LEAVING" , "THE" , "MAYOR" , "TO" , "GIVE" , "SQUIDWARD" , "COMMUNITY" , "SERVICE" , "FOR" , "THE" , "DAMAGE" , "HE" , "CAUSED" , "EVEN" , "THOUGH" , "SPONGEBOB" , "AND" , "PATRICK" , "WERE" , "IN" , "HIS" , "HOUSE" , "THE" , "WHOLE" , "FUCKING" , "TIME" , "AND" , "WERE" , "RESPONSIBLE" , "FOR" , "EVERYTHING"},
      new string[51]{"Yall" , "gone" , "make" , "me" , "act" , "a" , "fool" , "up" , "in" , "here" , "up" , "in" , "here" , "Yall" , "gone" , "make" , "me" , "loose" , "my" , "cool" , "up" , "in" , "here" , "up" , "in" , "here" , "Yall" , "gone" , "make" , "me" , "bust" , "a" , "smack" , "up" , "in" , "here" , "up" , "in" , "here" , "Yall" , "gone" , "make" , "my" , "fingers" , "snap" , "up" , "in" , "here" , "up" , "in" , "here"},
      new string[65]{"To" , "my" , "new" , "neighbors" , "Please" , "do" , "not" , "feel" , "it" , "necessary" , "to" , "call" , "the" , "police" , "if" , "you" , "hear" , "screaming" , "or" , "loud" , "banging" , "I" , "am" , "simply" , "testing" , "my" , "new" , "modules" , "on" , "the" , "people" , "trapped" , "in" , "my" , "basement" , "They" , "are" , "very" , "happy" , "to" , "be" , "here" , "and" , "have" , "volunteered" , "to" , "be" , "trapped" , "in" , "my" , "basement" , "Also" , "please" , "mow" , "your" , "lawn" , "at" , "more" , "normal" , "hours" , "of" , "the" , "morning" , "Thank" , "you"},
      new string[44]{"UH" , "OH" , "DICTATION" , "HAS" , "RUN" , "INTO" , "AN" , "ERROR" , "THIS" , "BOMB" , "IS" , "NOW" , "UNSOLVABLE" , "PLEASE" , "ACCEPT" , "YOUR" , "FATE" , "AND" , "DO" , "NOT" , "TRY" , "TO" , "SOLVE" , "ANYMORE" , "MODULES" , "ON" , "THIS" , "BOMB" , "ANY" , "ATTEMPT" , "TO" , "SOLVE" , "THIS" , "BOMB" , "WILL" , "RESULT" , "IN" , "CATASTROPHIC" , "FAILURE" , "THANK" , "YOU" , "FOR" , "YOUR" , "COOPERATION"},
      new string[59]{"Quote" , "okay" , "crazy" , "talk" , "Quote" , "one" , "two" , "four" , "three" , "end" , "quote" , "All" , "words" , "no" , "numbers" , "Wait" , "I" , "think" , "I" , "just" , "struck" , "on" , "the" , "needy" , "I" , "did" , "not" , "hear" , "it" , "go" , "off" , "because" , "of" , "Number" , "Cipher" , "Crap" , "Well" , "I" , "guess" , "we" , "just" , "have" , "to" , "blow" , "this" , "bomb" , "That" , "was" , "a" , "good" , "attempt" , "sorry" , "that" , "I" , "screwed" , "it" , "up" , "End" , "quote"},
      new string[71]{"Are" , "you" , "tired" , "of" , "running" , "bombs" , "of" , "ridiculous" , "sizes" , "Want" , "your" , "modules" , "to" , "take" , "more" , "reasonable" , "amounts" , "of" , "time" , "Well" , "for" , "the" , "low" , "price" , "of" , "twenty" , "nine" , "dollars" , "and" , "fifty" , "cents" , "you" , "can" , "buy" , "a" , "ton" , "of" , "games" , "that" , "are" , "way" , "better" , "than" , "this" , "one" , "Simply" , "open" , "the" , "shop" , "on" , "your" , "chosen" , "platform" , "and" , "begin" , "to" , "browse" , "the" , "large" , "array" , "of" , "time" , "wasting" , "games" , "that" , "will" , "not" , "make" , "you" , "hate" , "yourself"},
      new string[56]{"Do" , "you" , "ever" , "wonder" , "about" , "who" , "makes" , "these" , "bombs" , "I" , "mean" , "the" , "module" , "ideas" , "are" , "made" , "by" , "real" , "people" , "but" , "then" , "youre" , "given" , "the" , "bomb" , "right" , "Where" , "did" , "the" , "bomb" , "come" , "from" , "How" , "much" , "money" , "has" , "been" , "spent" , "on" , "creating" , "bombs" , "so" , "that" , "they" , "could" , "be" , "defused" , "for" , "fun" , "How" , "many" , "families" , "have" , "sued" , "this" , "company"},
      new string[49]{"Before" , "we" , "begin" , "this" , "message" , "was" , "sponsored" , "in" , "part" , "by" , "the" , "Colour" , "Talk" , "Pack" , "which" , "has" , "nothing" , "to" , "do" , "with" , "colours" , "It" , "was" , "also" , "sponsored" , "by" , "the" , "Trivia" , "Murder" , "Pack" , "which" , "is" , "sponsored" , "by" , "Jackbox" , "games" , "Thank" , "you" , "for" , "playing" , "Your" , "actual" , "message" , "will" , "begin" , "in" , "three" , "two" , "one"}
    };
    string CheckAids = "";
    string fucker = "";
    string AidsAids = ",./!?()*&^%@$#%-+=|[]{};:\"\'<>~\\";
    string SwanString = "SYSTEM FAILURE";

    bool AidsCheck;
    bool FuckAids;
    bool ineedabooleanname;
    bool HasBeenActivated;

    #pragma warning disable 414
    bool TwitchPlaysActive;
    #pragma warning restore 414

    static int moduleIdCounter = 1;
    int moduleId;
    private bool moduleSolved;

    void Awake () {
        moduleId = moduleIdCounter++;
        foreach (KMSelectable Key in SmallAssholes) {
            Key.OnInteract += delegate () { KeyPress(Key); return false; };
        }
        BackAssCrack.OnInteract += delegate () { BackAssCrackPress(); return false; };
        Lefttard.OnInteract += delegate () { DowniePress(); return false; };
        Bomb.OnBombExploded += delegate() { ineedabooleanname = true; };
    }

    void Start () {
      fuck = UnityEngine.Random.Range(0, Aids.Count());
    }

    void KeyPress (KMSelectable Key) {
      Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Key.transform);
      if (moduleSolved || FuckAids)
        return;
      Audio.PlaySoundAtTransform("Type3", transform);
      for (int i = 0; i < 27; i++) {
        if (Key == SmallAssholes[i]) {
          if (i == 26 && CheckAids.Length == 0)
            return;
          if (i == 26)
            CheckAids = CheckAids.Substring(0, CheckAids.Length - 1);
          else
            CheckAids = CheckAids + Namtar[i];
          AidsMongerer.text = CheckAids;
        }
      }
    }

    void BackAssCrackPress () {
      BackAssCrack.AddInteractionPunch();
      Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, BackAssCrack.transform);
      if (moduleSolved || FuckAids)
        return;
      if (!AidsCheck) {
        StartCoroutine(Uhhmm());
        CheckAids = "";
      }
    }

    void DowniePress () {
      Lefttard.AddInteractionPunch();
      Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Lefttard.transform);
      if (moduleSolved || FuckAids)
        return;
      if (CheckAids == "DETONATE") {
        Fanfare = 3f;
        TacoBell.color = new Color32(255,0,0,255);
        AidsMongerer.color = new Color32(255,0,0,255);
        StartCoroutine(MustDetonate());
        StartCoroutine(Swan());
        Debug.LogFormat("[Dictation #{0}] DETONATION SEQUENCE INITIATED!", moduleId);
        FuckAids = true;
      }
      else if (Aids[fuck][Ineedtopiss].ToLower() == CheckAids.ToLower()) {
        Audio.PlaySoundAtTransform("Dick", transform);
        moduleSolved = true;
        StartCoroutine(Fat());
      }
      else {
        GetComponent<KMBombModule>().HandleStrike();
        Debug.LogFormat("[Dictation #{0}] You submitted {1}. Strike, fasiofjnaldnfal.", moduleId, CheckAids);
        AidsMongerer.text = "Incorrect";
        TacoBell.text = "!";
        CheckAids = "";
      }
    }

    IEnumerator Uhhmm () {
      HasBeenActivated = true;
      Penis.GetComponent<MeshRenderer>().material = Penises[1];
      AidsCheck = true;
      for (int i = 0; i < Aids[fuck].Count(); i++) {
        AidsMongerer.text = Aids[fuck][i];
        NumAids += (float)Aids[fuck][i].Length * .09f;
        yield return new WaitForSecondsRealtime(NumAids);
        AidsMongerer.text = "";
        yield return new WaitForSecondsRealtime(NumAids / 2);
        NumAids = 0.05f;
        fucker = "";
      }
      Penis.GetComponent<MeshRenderer>().material = Penises[0];
      weed = UnityEngine.Random.Range(1,13);
      for (int i = 0; i < weed; i++)
        fucker += "-";
      AidsMongerer.text = fucker;
      Ineedtopiss = UnityEngine.Random.Range(0, Aids[fuck].Count());
      TacoBell.text = (Ineedtopiss + 1).ToString();
      AidsCheck = false;
      string Logmessage = "";
      for (int i = 0; i < Aids[fuck].Count(); i++)
        Logmessage += Aids[fuck][i] + " ";
      string Logaids = Aids[fuck][Ineedtopiss];
      Debug.LogFormat("[Dictation #{0}] The message is \"{1}\".", moduleId, Logmessage);
      Debug.LogFormat("[Dictation #{0}] It asks for word number {1}, which is \"{2}\".", moduleId, Ineedtopiss + 1, Logaids);
    }

    IEnumerator Fat () {
      Peepee = UnityEngine.Random.Range(0,Aids.Count());
      AidsMongerer.text = Aids[Peepee][UnityEngine.Random.Range(0,Aids[Peepee].Count())];
      TacoBell.text = (UnityEngine.Random.Range(0,100)).ToString();
      yield return new WaitForSeconds(Fanfare / 1000);
      Audio.PlaySoundAtTransform("Type3", transform);
      Fanfare += 1f;
      if (Fanfare >= 150f) {
        Audio.PlaySoundAtTransform("Dick", transform);
        Debug.LogFormat("[Dictation #{0}] You submitted the correct word. Module disarmed.", moduleId);
        GetComponent<KMBombModule>().HandlePass();
        TacoBell.text = "404";
        AidsMongerer.text = "System\nOverloaded";
        yield break;
      }
      StartCoroutine(Fat());
    }

    IEnumerator MustDetonate () {
      while (!ineedabooleanname) {
      yield return new WaitForSeconds(Fanfare);
      if (Fanfare != .5f)
        Fanfare -= .5f;
      if (!TwitchPlaysActive) {
        GetComponent<KMBombModule>().HandleStrike();
      }
      Debug.LogFormat("[Dictation #{0}] SYSTEM FAILURE!", moduleId);
    }
  }

    IEnumerator Swan () {
      while (true) {
        if (ineedanother % 2 == 0)
          Audio.PlaySoundAtTransform("Aids", transform);
        AidsMongerer.text = "";
        for (int i = 0; i < SwanString.Length; i++) {
          AidsMongerer.text += SwanString[i].ToString();
          TacoBell.text = AidsAids[UnityEngine.Random.Range(0,AidsAids.Length)].ToString();
          yield return new WaitForSeconds(.0765f);
        }
        ineedanother++;
      }
    }

    #pragma warning disable 414
    private readonly string TwitchHelpMessage = @"Use (!{0} begin) to start the message. Use (!{0} submit XXXX) to submit the word.";
    #pragma warning restore 414

    IEnumerator ProcessTwitchCommand(string command){
      int DumbassCheckass = 0;
      yield return null;
      if (Regex.IsMatch(command, @"^\s*begin\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)) {
        BackAssCrackPress();
        yield break;
      }
      command = command.Trim().ToUpper();
      string[] parameters = command.Split(' ');
      yield return null;
      if (parameters[0].ToLower() == "submit") {
        if (parameters.Length > 2)
          yield return "sendtochaterror Too many words!";
        else if (parameters.Length == 2) {
          if (parameters[0].ToLower() == "submit") {
            for (int i = 0; i < parameters[1].Length; i++) {
                        if (parameters[1].ToString().EqualsIgnoreCase("detonate"))
                        {
                            yield return "antitroll Nice try, asshole.";
                            yield return new string[] { "detonate" };
                        }
                        for (int j = 0; j < 26; j++) {
                if (parameters[1][i].ToString().ToUpper() == Namtar[j].ToString().ToUpper())
                  DumbassCheckass++;
              }
            }
            if (DumbassCheckass == parameters[1].Length) {
              for (int i = 0; i < parameters[1].Length; i++) {
                for (int j = 0; j < 26; j++) {
                  if (parameters[1][i].ToString().ToUpper() == Namtar[j].ToString()) {
                    SmallAssholes[j].OnInteract();
                    yield return new WaitForSeconds(.1f);
                  }
                }
              }
            }
            else {
              yield return "sendtochaterror Invalid Character!";
              CheckAids = "";
              AidsMongerer.text = CheckAids;
              yield break;
            }
            DowniePress();
            if (Aids[fuck][Ineedtopiss].ToLower() == CheckAids.ToLower())
              yield return "solve";
          }
          else
            yield return "sendtochaterror Invalid command!";
        }
        else if (parameters.Length < 2)
          yield return "sendtochaterror Too little words!";
      }
    }

    IEnumerator TwitchHandleForcedSolve () {
      if (!HasBeenActivated)
        BackAssCrack.OnInteract();
      while (AidsCheck)
        yield return null;
      int TemporaryForAutoSolver = CheckAids.Length;
      for (int i = 0; i < TemporaryForAutoSolver; i++) {
        SmallAssholes[26].OnInteract();
        yield return new WaitForSecondsRealtime(.1f);
      }
      for (int i = 0; i < Aids[fuck][Ineedtopiss].Length; i++) {
        SmallAssholes[Namtar.IndexOf(Aids[fuck][Ineedtopiss][i].ToString().ToUpper())].OnInteract();
        yield return new WaitForSecondsRealtime(.1f);
      }
      Lefttard.OnInteract();
    }
}
