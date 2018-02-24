module Program 

open System
open Common.Common
open Configuration
open Socket
open Log

let [<EntryPoint>] main _ = 
    let config = appConfig.Value
    let start, stop = createSocket config.QuickFixConfigFile log.Value
    start (); watchToExit (); stop (); 0
