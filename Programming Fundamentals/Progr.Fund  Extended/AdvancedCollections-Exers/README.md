# <p align="center"> Exercises: Advanced Collections<p>
 

Problems for exercises and homework for the [&quot;Programming Fundamentals&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

Check your solutions here: [https://judge.softuni.bg/Contests/433/Advanced-Collections-Exercises](https://judge.softuni.bg/Contests/433).

# 1.Shellbound

Vladi is a crab. Crabs are scared from almost anything, which is why they usually hide in their shells. Vladi is a rich crab though. He has acquired many outer shells, in different regions, in which he can hide – each with a different size.

However, it is really annoying to look after all your shells when they are so spread. That is why, Vladi decided to merge all shells in each region, so that he has one big shell for every region. He needs your help to do that.

You will be given several input lines containing a **string** and an **integer** , **separated** by a **space**. The **string** will represent the **region&#39;s name** , and the **integer** – the shell, in the **given region** , **size**.

You must store all shells in their corresponding regions.
If the region **already exists** , **add** the **new shell** to it. Make sure you have **NO** duplicate shells (shells with **same size** ). Vladi doesn&#39;t like shells with the same size.

When you receive the command &quot; **Aggregate**&quot;, you must stop reading input lines, and you must print **every region** , **all of the shells** in that region, and the **size** of the **giant shell** after you&#39;ve merged them in the following format:

**\{regionName} -&gt; {shell1, shell2, shell3…} ({giantShell})**

The giant shell size is calculated when you subtract the average of the shells from the sum of the shells.
Or in other words: **(sum of shells) – (sum of shells) / (count of shells)**.

### Examples

| **Input** | **Output** |
| --- | --- |
| Sofia 50 <br/> Sofia 20 <br/> Sofia 30 <br/> Varna 10 <br/> Varna 20 <br/> Aggregate | Sofia -&gt; 50, 20, 30 (67) <br/> Varna -&gt; 10, 20 (15) |
| Sofia 2 <br/> Sofia 1 <br/> Plovdiv 100 <br/> Plovdiv 50 <br/> Aggregate | Sofia -&gt; 2, 1 (2) <br/> Plovdiv -&gt; 100, 50 (75) |

### Constraints

- All numeric data should be represented with **integer** variables in **range [0, 1.000.000.000]**.

# 2.Dict-Ref-Advanced

Remember the DIct-Ref Problem from the previous exercise? Well this one is an Advanced Version.

You will begin receiving input lines containing information in one of the following formats:

- **{key} -&gt; {value1, value2, value3. . .}**
- **\{key} -&gt; \{otherKey}**

The **keys** will always be **strings** , and the **values** will always be **integers** , **separated** by a **comma** and a **space**.

If you are **given a key** and **values** , you must **store** the **values** to the **given key**. If the **key** already **exists** , you must **add** the **given values** to the old ones.

If you are **given a key** and **another key** , you must **copy** the **values** of the **other key** to the **first one**. If the **other key** **does not exist**, this input line must be **IGNORED**.

When you receive the command &quot; **end**&quot;, you must stop reading input lines, and you must print all keys with their values, in the following format:

**\{key} === {value1, value2, value3. . .}**

### Examples

| **Input** | **Output** |
| --- | --- |
| Isacc -&gt; 5, 4, 3 <br/> Peter -&gt; 6, 3, 3 <br/> Derek -&gt; 2, 2, 2 <br/> end | Isacc === 5, 4, 3 <br/> Peter === 6, 3, 3 <br/> Derek === 2, 2, 2 |
| Donald -&gt; 2, 2, 2 <br/> Isacc -&gt; 1 <br/> George -&gt; John <br/> John -&gt; Isaccend | Donald === 2, 2, 2 <br/> Isacc === 1 <br/> John === 1 |

# 3.Forum Topics

You have been tasked to store a few forum topics, and filter them by several given tags.
You will be given several input lines, containing data about topics in the following format:

**{topic} -&gt; {tag1, tag2, tag3. . .}**

**The**  **topic**  **and**  **tags**  **will be**  **strings** **. They will** **NOT** **contain** **spaces** **or &#39;** **-** **&#39;, &#39;** **&gt;** **&#39; symbols.**

**If you receive an**  **existent topic** **, you must** **add** **the** **new tags** **to it. There should be** **NO** **duplicate**  **tags.**

When you receive the command **“filter”**, you must end the input sequence. On the next line (**after “filter”**), you will receive a **sequence of tags, separated by a comma** and a **space**. You must print **ONLY** those topics, which **CONTAIN ALL** tags in the **given sequence**.

**The topics must be printed in the following format:**
**{topic} | {#tag1, #tag2, #tag3. . .}**

**NOTE:**  The tags have a  hashtag **(&#39;#&#39;)** as a **prefix**.

### Examples

| **Input** | **Output** |
| --- | --- |
| HelloWorld -&gt; hello, forum, topicHelp <br/> WithHomework -&gt; homework, forum, topic <br/> filter <br/> forum, topic | HelloWorld \| #hello, #forum, #topic <br/> HelpWithHomework \| #homework, #forum, #topic |
| First -&gt; this <br/> First -&gt; that <br/> First -&gt; who <br/> Second -&gt; this, what, why <br/> First -&gt; this <br/> Third -&gt; this, third <br/> Third -&gt; that <br/> filter <br/> that, this | First \| #this, #that, #who <br/> Third \| #this, #third, #that |

# 4. **Social Media Posts**

You have been tasked to create a Console Social Media Database.

You will receive several input lines in one of the following formats:

- post \{postName}
- like \{postName}
- dislike \{postName}
- comment \{postName} \{commentatorName} \{content}

If you receive the **post** command, you must **create** a **post** with the **given name**.

If you receive the **like** command you must **add** a **like** to the **given post**.

If you receive the **dislike** command you must add a **dislike** to the **given post**.

If you receive the **comment** command, you must **add** a **comment** to the **given post**. The **comment&#39;s** **writer **must be the** given commentator name**, and the content of the **comment **must be the** given content**.

By default the posts have **0 likes** , **0 dislikes** and **0 comments** , when created.

When you receive the command &quot; **drop the media**&quot; you must end the input sequence, and you must print every post with its likes, disliked and comments in the following format:

Post: {postName} \| Likes: {likes} \| Dislikes {dislikes} <br/>
Comments:<br/>
\*  \{commentator1}: \{comment1} <br/>
\*  \{commentator2}: \{comment2}
. . .

If a certain **post** does **NOT** have **ANY** comments, you should just print &quot; **None**&quot;.

The comments have a **prefix** of a **single**** asterisk**(&#39;**\***&#39;) and**2 spaces**.

There is **NO space** between the **commentator&#39;s name** and the **colon**.

### Examples

| **Input** | **Output** |
| --- | --- |
| post FirstPost <br/> like FirstPost <br/> like FirstPost <br/> dislike FirstPost <br/> post SecondPost <br/> comment FirstPost Isacc Cool <br/> comment SecondPost Isacc Lol <br/> like SecondPost <br/> drop the media | Post: FirstPost \| Likes: 2 \| Dislikes: 1 <br/> Comments: <br/> \*  Isacc: Cool <br/> Post: SecondPost \| Likes: 1 \| Dislikes: 0 <br/> Comments: <br/> \*  Isacc: Lol |
| post SomePost <br/> like SomePost <br/> like SomePost <br/> dislike SomePost <br/> post OtherPost <br/> comment OtherPost Isacc Naaais <br/> comment OtherPost Peter GoodPost <br/> comment OtherPost John Meh... <br/> drop the media | Post: SomePost \| Likes: 2 \| Dislikes: 1 <br/> Comments: <br/> NonePost: OtherPost \| Likes: 0 \| Dislikes: 0 <br/> Comments: <br/> \*  Isacc: Naaais <br/> \*  Peter: GoodPost <br/> \*  John: Meh... |

### Constraints

- The **post name** will be a **string** of **letters** and **digits**.
- The **commentator&#39;s name** will be a **string** of **letters**.
- The comment&#39;s **CONTENT** , may contain **ANY ASCII** character.
- There will be **NO invalid** input data.