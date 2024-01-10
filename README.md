# simple_encryption

This is a collection of some fun ciphers that you may have learned when you were young, built in C++ and C#.

# Why?

You can like, send cool secret messages to your friends if that's what you do. I don't know.

# Cool, which ciphers?

So far I've made...

- Morse encoder
- Caesar Shift
- NEW: Substitution cipher maker!

More coming soon. I think the caesar shift decryption method will be pretty easy, as you essentially just brute-force it.
Pull request for different ciphers. I couldn't think of any more than these, but Atbash is coming next.

# KNOWN BUGS

It's a pretty simple console application, but I could have done better. Actually, all the bugs in here are due to bad user input.
When you use this, know that you can't input numbers or punctuation because that would cause some translation trouble (they aren't in my letter array)

But yeah.

Also, I need to change the string to a <code>StringBuilder</code> because with usual strings, it's hilariously inefficient.

Anyway, check this out, and as I said, pull request if you want different ciphers.
