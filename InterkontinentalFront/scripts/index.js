import {loadFields, loadNumberOfGames, getActiveGame, incrementCounter} from './api.js'
import {newGameDiv, endGameDiv, mainHeader, goTop, newGameButton, statistics, container, loadMoreStatisticsBtn, loadAllStatisticsBtn, loadElements} from './elements.js'
import {showDefaultStatistics, loadStatisticsForMoreGames, loadAllGames} from './statistics.js'
import {addNewGame, showNewGameFields} from './newGame.js'
import { endGame } from './endGame.js'

export let fields 
export let gameId
export let numberOfGames

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

export const setMainHeader = (val) => {
    mainHeader.innerText = val
}

export const increment = async (gameIdentifier, field, button) => {
    var data = await incrementCounter(gameIdentifier, field.id)
    button.innerHTML = field.name + '<i class="fa-solid fa-plus"></i>' + "<br/>Ilość: " + data
}

export const loadStatisticsOrNewGame = async (id) => {
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

const createEndGameButton = () => {
    const btn = document.createElement('button')
    btn.innerText = 'Zakończ grę'
    btn.addEventListener('click', async () => numberOfGames += await endGame(gameId))
    endGameDiv.innerHTML = ''
    endGameDiv.appendChild(btn)
    endGameDiv.classList.toggle('hide')
}

export const listen = () => {
    newGameButton.addEventListener('click', async () => gameId = await addNewGame())
    loadMoreStatisticsBtn.addEventListener('click', async () => await loadStatisticsForMoreGames())
    loadAllStatisticsBtn.addEventListener('click', async () => await loadAllGames())
    goTop.addEventListener('click', () => goToTop())
}

const goToTop = () => {
    window.scrollTo(0, container.offsetTop);
}