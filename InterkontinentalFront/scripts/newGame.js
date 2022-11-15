import {increment, gameId, fields, loadStatisticsOrNewGame} from './index.js'
import { getActiveCounters, getNewGame } from './api.js'
import { newGameContent } from './elements.js'

export const addNewGame = async () => {
    const gId = await getNewGame()
    await loadStatisticsOrNewGame(gameId)

    return gId
}

export const showNewGameFields = async () => {

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

