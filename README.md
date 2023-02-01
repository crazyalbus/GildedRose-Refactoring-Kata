# Gilded Rose Refactoring Kata

## Clare's Intro

This is a fork from [Emily Bache's original repo](https://github.com/emilybache/GildedRose-Refactoring-Kata) - created so I can issue some PRs.

Note that I also have an entirely separate repo - [gilded-rose-kata](https://github.com/claresudbery/gilded-rose-kata) - which is a *copy* of the original. I created this so that I could do some actual refactoring, but to be honest I'm now thinking I could also have done that in the fork. Maybe I'll sort that out at some point.

Note that I also added a section to my [clare-wiki](https://clare-wiki.herokuapp.com/pages/think/code-princ/Refactoring#approval-testing) which has a few more notes on getting started with approval testing.

## A note on branches

Note that I have another version of this repo, not a fork, which has its own readme. 
  - It's mostly deprecated now - you probably want to ignore it.

At the time of writing, the following branches exist in this repo:

- Branches designed to be merged with new branches:
  - `clare-fork-readme` 
    - Created purely to contain this forked version of the main readme 
    - Designed to be merged into any new branches
  - `csharp-approval-fixes`
    - Created to house changes I needed to make to get approval tests working in C# code
    - A [PR has been issued](https://github.com/emilybache/GildedRose-Refactoring-Kata/pull/402) to get this merged into Emily's source
  - `requirements-edit`
    - Edited version of the Gilded Rose requirements
    - A [PR has been issued](https://github.com/emilybache/GildedRose-Refactoring-Kata/pull/403) to get this merged into Emily's source
- Branches created for workshops and demos:
  - `csharp-liftup-start`
    - Starting point for participants in a "lift up conditional" workshop
    - See [Emily's demo video](https://www.youtube.com/watch?v=OJmg9aMxPDI)
  - `csharp-liftup-demo`
    - Designed to contain demo commits for the lift up conditional technique 
    - Based on the `csharp-liftup-start` branch
    - I may or may not have got round to actually adding the demo commits
  - `oreilly-refactoring-demo`
    - I think I created this when I was demoing code the first time I ran the O'Reilly Refactoring Fundamentals course
  - `oreilly-refactoring-demo-v2`
    - Looks like I created this when I was demoing code the *second* time I ran the O'Reilly Refactoring Fundamentals course

## Emily's Intro

This Kata was originally created by Terry Hughes (http://twitter.com/TerryHughes). It is already on GitHub [here](https://github.com/NotMyself/GildedRose). See also [Bobby Johnson's description of the kata](https://iamnotmyself.com/refactor-this-the-gilded-rose-kata/).

I translated the original C# into a few other languages, (with a little help from my friends!), and slightly changed the starting position. This means I've actually done a small amount of refactoring already compared with the original form of the kata, and made it easier to get going with writing tests by giving you one failing unit test to start with. I also added test fixtures for Text-Based approval testing with TextTest (see [the TextTests](https://github.com/emilybache/GildedRose-Refactoring-Kata/tree/master/texttests))

As Bobby Johnson points out in his article ["Why Most Solutions to Gilded Rose Miss The Bigger Picture"](https://iamnotmyself.com/why-most-solutions-to-gilded-rose-miss-the-bigger-picture/), it'll actually give you
better practice at handling a legacy code situation if you do this Kata in the original C#. However, I think this kata
is also really useful for practicing writing good tests using different frameworks and approaches, and the small changes I've made help with that. I think it's also interesting to compare what the refactored code and tests look like in different programming languages.

I use this kata as part of my work as a technical coach. I wrote a lot about the coaching method I use in this book [Technical Agile Coaching with the Samman method](https://leanpub.com/techagilecoach). A while back I wrote this article ["Writing Good Tests for the Gilded Rose Kata"](http://coding-is-like-cooking.info/2013/03/writing-good-tests-for-the-gilded-rose-kata/) about how you could use this kata in a [coding dojo](https://leanpub.com/codingdojohandbook).

## How to use this Kata

The simplest way is to just clone the code and start hacking away improving the design. You'll want to look at the ["Gilded Rose Requirements"](https://github.com/emilybache/GildedRose-Refactoring-Kata/tree/master/GildedRoseRequirements.txt) which explains what the code is for. I strongly advise you that you'll also need some tests if you want to make sure you don't break the code while you refactor.

You could write some unit tests yourself, using the requirements to identify suitable test cases. I've provided a failing unit test in a popular test framework as a starting point for most languages.

Alternatively, use the "Text-Based" tests provided in this repository. (Read more about that in the next section)

Whichever testing approach you choose, the idea of the exercise is to do some deliberate practice, and improve your skills at designing test cases and refactoring. The idea is not to re-write the code from scratch, but rather to practice designing tests, taking small steps, running the tests often, and incrementally improving the design. 

### Gilded Rose Requirements in other languages 

- [English](GildedRoseRequirements.txt)
- [Español](GildedRoseRequirements_es.md)
- [Français](GildedRoseRequirements_fr.md)
- [日本語](GildedRoseRequirements_jp.md)
- [Português](GildedRoseRequirements_pt-BR.md)
- [Русский](GildedRoseRequirements_ru.txt)
- [ไทย](GildedRoseRequirements_th.md)
- [中文](GildedRoseRequirements_zh.txt)
- [한국어](GildedRoseRequirements_kr.md)
- [German](GildedRoseRequirements_de.md)

## Text-Based Approval Testing

Most language versions of this code have a [TextTest](https://texttest.org) fixture for Approval testing. For information about this, see the [TextTests README](https://github.com/emilybache/GildedRose-Refactoring-Kata/tree/master/texttests)

Note from Clare: You can also see my [clare-wiki section](https://clare-wiki.herokuapp.com/pages/think/code-princ/Refactoring#approval-testing) which has a few more notes on getting started.

## Translating this code

More translations are most welcome! I'm very open for pull requests that translate the starting position into additional languages. 

Please note a translation should ideally include:

- a translation of the production code for 'update_quality' and Item
- one failing unit test complaining that "fixme" != "foo"
- a TextTest fixture, ie a command-line program that runs update_quality on the sample data for the number of days specified.

Please don't write too much code in the starting position or add too many unit tests. The idea with the one failing unit test is to tempt people to work out how to fix it, discover it wasn't that hard, and now they understand what this test is doing they realize they can improve it.  

If your programming language doesn't have an easy way to add a command-line interface, then the TextTest fixture is probably not necessary.

