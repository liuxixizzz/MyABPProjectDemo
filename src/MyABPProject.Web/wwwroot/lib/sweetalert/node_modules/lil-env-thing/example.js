const env = require('lil-env-thing')

// Assuming process.env.NODE_ENV is undefined:

env.test          // false
env.development   // false
env.production    // false
env.current       // undefined


process.env.NODE_ENV = 'test'

env.test          // true
env.development   // false
env.production    // false
env.current       // 'test'
