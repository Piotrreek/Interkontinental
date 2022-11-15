export const baseURL = 'https://localhost:8000/'

export const loadFields = async () => {
    const res = await fetch(`${baseURL}game/fields`)
    const data = await res.json()

    return data;
}

export const loadNumberOfGames = async () => {
    const res = await fetch(`${baseURL}game/number-of-games`)
    const data = await res.json()

    return data
}

export const getNewGame = async () => {
    const res = await fetch(`${baseURL}game/create`)
    const data = await res.text()
    
    return data
}

export const getActiveGame = async () => {
    var res = await fetch(`${baseURL}game/get-active-game`)
    if(res.status === 404)
        return 0;
    const data = await res.text()

    return data
}

export const getActiveCounters = async (gameId) => {
    const res = await fetch(`${baseURL}game/${gameId}/get-active-counters`)
    const data = await res.json()

    return data
}

export const incrementCounter = async (gameId, fieldId) => {
    var res = await fetch(`${baseURL}game/${gameId}/field-increment/${fieldId}`)
    var data = await res.text()
    
    return data
}

export const end = async (gameId) => {
    var res = await fetch(`${baseURL}game/end/${gameId}`)
    var data = await res.text()

    return data
}

export const showStatistics = async (start, end) => {
    const res = await fetch(`${baseURL}game/get-statistics?start=${start}&end=${end}`)
    const data = await res.json()

    return data
}

