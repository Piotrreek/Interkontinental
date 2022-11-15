let newGameContent 
let newGameDiv 
let endGameDiv
let mainHeader 
let statistics 
let newGameButton
let loadMoreStatisticsBtn
let loadMoreStatisticsDiv
let loadAllStatisticsBtn
let goTop
let container
const baseURL = 'https://localhost:8000/'

let fields 
let gameId
let numberOfGames
let statisticsGameCounter = 4

document.addEventListener('DOMContentLoaded', () => {
    main()
})

const main = async () => {
    loadElements()
    listen()
    fields = await loadFields()
    gameId = await getActiveGame()
    numberOfGames = await loadNumberOfGames()
    await loadStatisticsOrNewGame(gameId)
}

const createEndGameButton = () => {
    const btn = document.createElement('button')
    btn.innerText = 'Zakończ grę'
    btn.addEventListener('click', () => endGame(gameId))
    endGameDiv.innerHTML = ''
    endGameDiv.appendChild(btn)
    endGameDiv.classList.toggle('hide')
}

const setMainHeader = (val) => {
    mainHeader.innerText = val
}

const getActiveGame = async () => {
    var res = await fetch(`${baseURL}game/get-active-game`)
    if(res.status === 404)
        return 0;
    data = await res.text()

    return data
}

const getActiveCounters = async (gameId) => {
    const res = await fetch(`${baseURL}game/${gameId}/get-active-counters`)
    const data = await res.json()
    return data
}

const increment = async (gameIdentifier, field, button) => {
    var res = await fetch(`${baseURL}game/${gameIdentifier}/field-increment/${field.id}`)
    var data = await res.text()

    button.innerHTML = field.name + '<i class="fa-solid fa-plus"></i>' + "<br/>Ilość: " + data
}

const endGame = (gameIdentifier) => {
    setMainHeader('Interkontinental')
    newGameDiv.classList.toggle('hide')
    endGameDiv.classList.toggle('hide')
    loadAllStatisticsBtn.classList.remove('hide')
    loadMoreStatisticsBtn.classList.remove('hide')
    newGameContent.innerText = ''
    newGameContent.classList.toggle('hide')
    showDefaultStatistics()
    numberOfGames += 1

    fetch(`${baseURL}game/end/${gameIdentifier}`)
    .then((response) => response.text())
    .then((data) => {
    })
}

const getNewGame = async () => {
    const res = await fetch(`${baseURL}game/create`)
    const data = await res.text()
    
    return data
}

const addNewGame = async () => {
    gameId = await getNewGame()
    await loadStatisticsOrNewGame(gameId)
}

const showDefaultStatistics = async () => {
    statisticsGameCounter = 4
    const res = await fetch(`${baseURL}game/get-statistics?start=${statisticsGameCounter - 4}&end=${statisticsGameCounter - 2}`)
    const data = await res.json()
    
    data.map((game) => loadStatisticsSingleGame(game))
}

const loadStatisticsForMoreGames = async () => {
    const res = await fetch(`${baseURL}game/get-statistics?start=${statisticsGameCounter - 2}&end=${statisticsGameCounter}`)
    const data = await res.json()
    statisticsGameCounter += 2
    
    data.map((game) => loadStatisticsSingleGame(game))
}

const loadAllGames = async () => {
    const res = await fetch(`${baseURL}game/get-statistics?start=${statisticsGameCounter - 2}&end=${numberOfGames}`)
    const data = await res.json()
    loadMoreStatisticsBtn.classList.add('hide')
    loadAllStatisticsBtn.classList.add('hide')
    
    data.map((game) => loadStatisticsSingleGame(game))
}

const loadStatisticsSingleGame = (game) => {
    const gameSection = document.createElement('section')
        gameSection.classList.add('game')
        const h2Time = document.createElement('h2')
        h2Time.classList.add('statistics__time')
        h2Time.innerText = 'Gra z dnia: ' + game.start + ' - ' + game.end
        statistics.appendChild(h2Time)
        fields.map((type) => {
            const h2 = document.createElement('h2')
            h2.classList.add('statistics__country-name')
            h2.innerText = type[0].type
            gameSection.appendChild(h2)
            const div = document.createElement('div')
            div.classList.add('statistics__country')
            type.map((field) => {
                const counter = game.counters.find(({fieldId}) => fieldId === field.id)
                const divField = document.createElement('div')
                divField.classList.add('statistics__field')
                divField.innerHTML = field.name + "<br/>Ilość: " + counter.count
                div.appendChild(divField)
            })
            gameSection.appendChild(div)
        })
        gameSection.classList.add('hide')
        statistics.appendChild(gameSection)
        const showGameDiv = document.createElement('div')
        showGameDiv.classList.add('show-more-btn')
        const showGameBtn = document.createElement('button')
        showGameBtn.innerHTML = 'Rozwiń<br/>' + '<i class="fa-sharp fa-solid fa-arrow-down"></i>'
        showGameBtn.addEventListener('click', () => {
            gameSection.classList.toggle('hide')
            if(!gameSection.classList.contains('hide'))
                showGameBtn.innerHTML = 'Zwiń<br/>' + '<i class="fa-sharp fa-solid fa-arrow-up"></i>'
            else
                showGameBtn.innerHTML = 'Rozwiń<br/>' + '<i class="fa-sharp fa-solid fa-arrow-down"></i>'
        })
        showGameDiv.appendChild(showGameBtn)
        statistics.appendChild(showGameDiv)
}

const showNewGameFields = async () => {

    const activeCounters = await getActiveCounters(gameId)

    fields.map((type) => {
        const h2 = document.createElement('h2')
        h2.innerText = type[0].type
        newGameContent.appendChild(h2)
        const div = document.createElement('div')
        div.classList.add('add-new-game__content__country')
        type.map((field) => {
            const counter = activeCounters.find(({fieldId}) => fieldId === field.id)
            const divButton = document.createElement('div')
            divButton.classList.add('add-new-game__content__field')
            const button = document.createElement('button')
            button.innerHTML = field.name + '<i class="fa-solid fa-plus"></i>' + "<br/>Ilość: " + counter.count
            button.addEventListener('click', () => {
                increment(gameId, field, button)
            })
            divButton.appendChild(button)
            div.appendChild(divButton)
        })
        newGameContent.appendChild(div)
    })  
}

const loadStatisticsOrNewGame = async (id) => {
    if(id === 0){
        showDefaultStatistics()
    }else{
        statistics.innerHTML = ''
        setMainHeader('Interkontinental - Tworzenie Nowej Gry')
        newGameDiv.classList.toggle('hide')
        createEndGameButton()
        await showNewGameFields()
    }
}

const loadElements = () => {
    newGameContent = document.querySelector('.add-new-game__content')
    newGameDiv = document.querySelector('.add-new-game__button')
    endGameDiv = document.querySelector('.end-new-game__button')
    mainHeader = document.querySelector('.page__header')
    statistics = document.querySelector('.game-statistics')
    newGameButton = document.querySelector('.add-new-game')
    loadMoreStatisticsBtn = document.querySelector('.load-more-statistics-btn')
    loadMoreStatisticsDiv = document.querySelector('.load-more-statistics-div')
    loadAllStatisticsBtn = document.querySelector('.load-all-statistics-btn')
    goTop = document.querySelector('.go-top')
    container = document.querySelector('.container')
}

const listen = () => {
    newGameButton.addEventListener('click', async () => await addNewGame())
    loadMoreStatisticsBtn.addEventListener('click', async () => await loadStatisticsForMoreGames())
    loadAllStatisticsBtn.addEventListener('click', async () => await loadAllGames())
    goTop.addEventListener('click', () => goToTop())
}

const loadFields = async () => {
    const res = await fetch(`${baseURL}game/fields`)
    const data = await res.json()
    return data;
}

const loadNumberOfGames = async () => {
    const res = await fetch(`${baseURL}game/number-of-games`)
    const data = await res.json()
    return data
}

const goToTop = () => {
    window.scrollTo(0, container.offsetTop);
}

